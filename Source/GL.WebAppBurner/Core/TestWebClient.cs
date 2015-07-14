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
using System.Linq;
using System.Net;

namespace GL.WebAppBurner.Core
{
    public class TestWebClient : WebClient
    {
        #region Constructors

        public TestWebClient()
        {
            CookieContainer = new CookieContainer();
            Timeout = 30000;
        }

        #endregion

        #region Methods

        protected override WebRequest GetWebRequest(Uri address)
        {
            WebRequest request = base.GetWebRequest(address);
            if (request is HttpWebRequest)
            {
                ((HttpWebRequest)request).CookieContainer = CookieContainer;
            }
            request.Timeout = Timeout;
            return request;
        }

        protected override WebResponse GetWebResponse(WebRequest request)
        {
            WebResponse response = base.GetWebResponse(request);
            if (response.Headers[HttpResponseHeader.SetCookie] != null)
            {
                CookieContainer.SetCookies(response.ResponseUri, response.Headers[HttpResponseHeader.SetCookie]);
            }
            return response;
        }

        public void AddCookie(string url, string name, string value, string path)
        {
            this.CookieContainer.Add(new Uri(url), new Cookie(name, value, path));
        }

        public void SetCookies(string url, string cookieHeader)
        {
            this.CookieContainer.SetCookies(new Uri(url), cookieHeader);
        }

        public void RemoveCookie(string url, string name)
        {
            foreach(Cookie cookie in this.CookieContainer.GetCookies(new Uri(url)))
            {
                if (cookie.Name == name) { cookie.Expired = true; }
            }
        }

        public void RemoveCookie(string url, string name, string path)
        {
            foreach (Cookie cookie in this.CookieContainer.GetCookies(new Uri(url)))
            {
                if (cookie.Name == name && cookie.Path == path) { cookie.Expired = true; }
            }
        }

        public void ClearCookies(string url)
        {
            foreach (Cookie cookie in this.CookieContainer.GetCookies(new Uri(url)))
            {
                cookie.Expired = true;
            }
        }

        #endregion

        #region Properties

        public CookieContainer CookieContainer { get; private set; }

        public int Timeout { get; set; }

        #endregion
    }
}
