/***
 *  Copyright (C) 2015, Jérémy WALTHER (jeremy.walther@golflima.net)
 *
 *  This file is part of WebAppBurner (GL.WebAppBurner).
 *  GL.WebAppBurner, Benchmarking tool for web applications.
 * 
 *  WebAppBurner is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation, either version 3 of the License, or
 *  (at your option) any later version.
 *
 *  WebAppBurner is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU General Public License for more details.
 *
 *  You should have received a copy of the GNU General Public License
 *  along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

using GL.MetaN.ReflectionConsole;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

namespace GL.WebAppBurner.Core
{
    public class TestWorker
    {
        #region Fields

        private readonly List<TestRequestInfo> testRequests;
        private readonly int maxIterations;

        private List<TestRequestResult> testResults;

        #endregion

        #region Constructors

        public TestWorker(int id, List<TestRequestInfo> requests, int iterations)
        {
            if (requests == null) { throw new ArgumentNullException("requests"); }
            if (iterations < 1) { throw new ArgumentOutOfRangeException("iterations", iterations, "iterations must be greater than 0."); }
            Id = id;
            this.testRequests = requests;
            this.maxIterations = iterations;
            this.testResults = new List<TestRequestResult>();
            Thread = new Thread(this.Work) { Name = "TestWorker_" + Id };
        }

        #endregion

        #region Methods

        public void Stop() { StopRequested = true; }

        public void Start()
        {
            Thread.Start();
        }

        public void Restart()
        {
            Thread = new Thread(this.Work) { Name = "TestWorker_" + Id };
            Thread.Start();
        }

        private void Work()
        {
            IsRunning = true;
            StopRequested = false;
            Stopwatch swHttp = new Stopwatch(), swIteration = new Stopwatch();
            TestRequestResult result;
            DateTime start;
            string response, scriptBeforeResult, error;
            WebExceptionStatus errorCode;
            while (!StopRequested && Iterations < MaxIterations)
            {
                Iterations++;
                swIteration.Start();
                using (TestWebClient webClient = new TestWebClient() { Timeout = TestWorker.RequestsTimeout })
                {
                    TestCommander commander = new TestCommander(this, webClient);
                    CommandContainerCollection ccc = new CommandContainerCollection()
                    {
                        new CommandContainer(commander, "Commander"),
                        new CommandContainer(this, "Worker"),
                        new CommandContainer(webClient, "WebClient"),
                        new CommandContainer(webClient.CookieContainer, "Cookies"),
                        new CommandContainer(webClient.Headers, "Headers"),
                    };
                    ccc.SelectContainer("Commander");
                    foreach (TestRequestInfo request in this.testRequests)
                    {
                        if (StopRequested) { break; }
                        errorCode = WebExceptionStatus.Success;
                        error = null;
                        start = DateTime.Now;
                        ccc.Add(new CommandContainer(request, "Request")); commander.Request = request;
                        try { scriptBeforeResult = request.ScriptBefore == null ? null : (ccc.ExecuteCommand(request.ScriptBefore) ?? "").ToString(); }
                        catch (Exception e) { scriptBeforeResult = e.Message; }
                        IsWaiting = true;
                        try
                        {
                            if (request.PostData == null)
                            {
                                webClient.Headers.Remove(HttpRequestHeader.ContentType);
                                if (commander.Burning)
                                {
                                    response = null;
                                    error = "Burning";
                                    swHttp.Start();
                                    webClient.DownloadStringAsync(new Uri(request.Url));
                                    webClient.CancelAsync();
                                }
                                else
                                {
                                    swHttp.Start();
                                    response = webClient.DownloadString(request.Url);
                                }
                            }
                            else
                            {
                                webClient.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
                                if (commander.Burning)
                                {
                                    response = null;
                                    error = "Burning";
                                    swHttp.Start();
                                    webClient.UploadStringAsync(new Uri(request.Url), request.PostData);
                                    webClient.CancelAsync();
                                }
                                else
                                {
                                    swHttp.Start();
                                    response = webClient.UploadString(request.Url, request.PostData);
                                }
                            }
                        }
                        catch (WebException we)
                        {
                            response = null;
                            errorCode = we.Status;
                            error = we.Message;
                        }
                        catch(Exception e)
                        {
                            response = null;
                            errorCode = WebExceptionStatus.UnknownError;
                            error = e.Message;
                        }
                        swHttp.Stop();
                        IsWaiting = false;
                        result = new TestRequestResult(request)
                        {
                            Duration = swHttp.Elapsed,
                            Start = start,
                            WorkerId = Id,
                            Status = errorCode,
                            Valid = request.ResultValidation == null || response == null ? 
                                default(Nullable<bool>) : new Regex(request.ResultValidation, RegexOptions.Singleline).Match(response).Success,
                            Length = response == null ? default(Nullable<int>) : response.Length,
                            Iteration = Iterations,
                            ScriptBeforeResult = scriptBeforeResult,
                            Error = error,
                        };
                        if (request.ResultDataExtract != null && response != null)
                        {
                            StringBuilder data = new StringBuilder();
                            Match match = new Regex(request.ResultDataExtract, RegexOptions.Singleline).Match(response);
                            while (match.Success)
                            {
                                data.Append(match.Value);
                                match = match.NextMatch();
                                if (match.Success) { data.Append(request.ResultDataSeparator); }
                            }
                            result.DataExtracted = data.ToString();
                        }
                        ccc.StoredValues["Response"] = response; commander.ResponseString = response;
                        ccc.Remove("Result"); ccc.Add(new CommandContainer(result, "Result")); commander.Result = result;
                        try { result.ScriptAfterResult = request.ScriptAfter == null ? null : (ccc.ExecuteCommand(request.ScriptAfter) ?? "").ToString(); }
                        catch (Exception e) { result.ScriptAfterResult = e.Message; }
                        ccc.Remove("Request");
                        swHttp.Reset();
                        this.testResults.Add(result);
                        Requests++;
                    }
                }
                swIteration.Stop();
                LastIterationRunTime = swIteration.Elapsed;
                swIteration.Reset();
            }
            IsRunning = false;
            Done = Iterations == MaxIterations;
        }

        #endregion

        #region Properties

        public bool IsRunning { get; private set; }
        public bool IsWaiting { get; private set; }
        public bool StopRequested { get; private set; }
        public bool Done { get; private set; }

        public int Id { get; private set; }
        public int Iterations { get; private set; }
        public int Requests { get; private set; }
        public int MaxIterations { get { return this.maxIterations; } }

        public ReadOnlyCollection<TestRequestInfo> TestRequests { get { return this.testRequests.AsReadOnly(); } }
        public ReadOnlyCollection<TestRequestResult> TestResults { get { return this.testResults.AsReadOnly(); } }

        public TimeSpan? LastIterationRunTime { get; private set; }
        public TimeSpan? EstimatedRemainingTime
        {
            get
            {
                return LastIterationRunTime.HasValue ? TimeSpan.FromTicks(LastIterationRunTime.Value.Ticks * (MaxIterations - Iterations)) : default(Nullable<TimeSpan>);
            }
        }

        public Thread Thread { get; private set; }

        #endregion

        #region Static Properties

        public static int RequestsTimeout { get; set; }

        #endregion
    }
}
