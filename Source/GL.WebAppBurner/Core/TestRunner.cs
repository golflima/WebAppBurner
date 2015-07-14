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

using System;
using System.Collections.Generic;
using System.Linq;

namespace GL.WebAppBurner.Core
{
    public class TestRunner
    {
        #region Fields

        private readonly List<TestRequestInfo> testRequests;
        private readonly int maxIterations;
        private readonly int maxWorkers;

        private readonly List<TestWorker> workers;

        #endregion

        #region Constructors

        public TestRunner(List<TestRequestInfo> requests, int iterations, int workers)
        {
            if (requests == null) { throw new ArgumentNullException("requests"); }
            if (iterations < 1) { throw new ArgumentOutOfRangeException("iterations", iterations, "iterations must be greater than 0."); }
            if (workers < 1) { throw new ArgumentOutOfRangeException("workers", workers, "workers must be greater than 0."); }
            this.testRequests = requests;
            this.maxIterations = iterations;
            this.maxWorkers = workers;

            this.workers = new List<TestWorker>(workers);
            for(int i = 0; i<workers; i++)
            {
                this.workers.Add(new TestWorker(i + 1, requests, iterations));
            }

            System.Net.ServicePointManager.DefaultConnectionLimit = iterations * workers;
        }

        #endregion

        #region Methods

        public void Start()
        {
            this.workers.ForEach(w => w.Start());
        }

        public void Restart()
        {
            this.workers.ForEach(w => w.Restart());
        }

        public void Stop()
        {
            this.workers.ForEach(w => w.Stop());
        }

        public void Kill()
        {
            this.workers.ForEach(w => w.Thread.Abort());
        }

        #endregion

        #region Properties

        public TimeSpan? EstimatedRemainingTime
        {
            get
            {
                TimeSpan? remaining = null;
                foreach(TestWorker worker in this.workers)
                {
                    if(worker.EstimatedRemainingTime.HasValue)
                    {
                        if (remaining == null || worker.EstimatedRemainingTime.Value.Ticks > remaining.Value.Ticks) { remaining = worker.EstimatedRemainingTime; }
                    }
                }
                return remaining;
            }
        }

        public int RunningWorkerCount { get { return this.workers.Count(w => w.IsRunning); } }
        public int WaitingWorkerCount { get { return this.workers.Count(w => w.IsWaiting); } }
        public int MaxRequests { get { return this.maxIterations * this.maxWorkers * this.testRequests.Count; } }
        public int RequestCount { get { int count = 0; this.workers.ForEach(w => count += w.Requests); return count; } }

        public IEnumerable<TestRequestResult> TestResults
        {
            get 
            { 
                List<TestRequestResult> results = new List<TestRequestResult>(); 
                this.workers.ForEach(w => results.AddRange(w.TestResults));
                return results.OrderBy(r => r.Start.Ticks);
            }
        }

        public bool Done { get { return this.workers.Count == this.workers.Count(w => w.Done); } }
        public bool IsRunning { get { return RunningWorkerCount > 0; } }

        #endregion
    }
}
