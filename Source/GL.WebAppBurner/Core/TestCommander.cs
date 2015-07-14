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

namespace GL.WebAppBurner.Core
{
    class TestCommander
    {
        #region Constructors

        public TestCommander(TestWorker worker, TestWebClient webClient)
        {
            if (worker == null) { throw new ArgumentNullException("worker"); }
            if (webClient == null) { throw new ArgumentNullException("webClient"); }
            Worker = worker;
            WebClient = webClient;
        }

        #endregion

        #region Methods

        public void Burn() { Burning = true; }
        public void BurnOut() { Burning = false; }

        public string Response() { return ResponseString; }

        public string Url() { return Request == null ? null : Request.Url; }
        public void Url(string url) { if (Request != null) { Request.Url = url; } }
        public string UrlFormat(params object[] args)
        {
            if (Request != null) { Request.Url = String.Format(Request.Url, args); return Request.Url; }
            return null;
        }

        public string PostData() { return Request == null ? null : Request.PostData; }
        public void PostData(string postData) { if (Request != null) { Request.PostData = postData; } }
        public string PostDataFormat(params object[] args)
        {
            if (Request != null) { Request.PostData = String.Format(Request.PostData, args); return Request.PostData; }
            return null;
        }

        public int Timeout() { return WebClient.Timeout; }
        public void Timeout(int timeout) { WebClient.Timeout = timeout; }

        public void AddCookie(string url, string name, string value, string path) { WebClient.AddCookie(url, name, value, path); }
        public void SetCookies(string url, string cookieHeader) { WebClient.SetCookies(url, cookieHeader); }
        public void RemoveCookie(string url, string name) { WebClient.RemoveCookie(url, name); }
        public void RemoveCookie(string url, string name, string path) { WebClient.RemoveCookie(url, name, path); }
        public void ClearCookies(string url) { WebClient.ClearCookies(url); }

        #endregion

        #region Properties

        public bool Burning { get; set; }

        internal TestWebClient WebClient { get; private set; }
        internal TestWorker Worker { get; private set; }
        internal TestRequestInfo Request { get; set; }
        internal TestRequestResult Result { get; set; }
        internal string ResponseString { get; set; } 

        #endregion
    }
}
