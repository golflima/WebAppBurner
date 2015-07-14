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
using System.Net;
using System.Xml.Serialization;

namespace GL.WebAppBurner.Core
{
    [Serializable]
    public class TestRequestResult
    {
        private TestRequestInfo requestInfo;

        public TestRequestResult() : this(null) { } // For serialization only
        
        public TestRequestResult(TestRequestInfo requestInfo)
        {
            if (requestInfo == null) { throw new ArgumentNullException("requestInfo"); }
            this.requestInfo = requestInfo;
        }

        [XmlElement]
        public DateTime Start { get; set; }

        [XmlElement]
        public int WorkerId { get; set; }

        [XmlElement]
        public int Iteration { get; set; }

        //public TestRequestInfo RequestInfo { get { return this.requestInfo; } set { } }

        [XmlElement]
        public string Name { get { return this.requestInfo.Name; } set { /* for xml serialization */ } }

        [XmlElement]
        public string Url { get { return this.requestInfo.Url; } set { /* for xml serialization */ } }

        [XmlElement]
        public string PostData { get { return this.requestInfo.PostData; } set { /* for xml serialization */ } }

        [XmlIgnore]
        public TimeSpan Duration { get; set; }

        [XmlElement]
        public int Milliseconds { get { return (int)Duration.TotalMilliseconds; } set { /* for xml serialization */ } }

        [XmlElement]
        public WebExceptionStatus Status { get; set; }

        [XmlElement]
        public string Error { get; set; }

        [XmlElement]
        public int? Length { get; set; }

        [XmlElement]
        public string Validation { get { return this.requestInfo.ResultValidation; } set { /* for xml serialization */ } }

        [XmlElement]
        public bool? Valid { get; set; }

        [XmlElement]
        public string DataExtract { get { return this.requestInfo.ResultDataExtract; } set { /* for xml serialization */ } }

        [XmlElement]
        public string DataSeparator { get { return this.requestInfo.ResultDataSeparator; } set { /* for xml serialization */ } }

        [XmlElement]
        public string DataExtracted { get; set; }

        [XmlElement]
        public string ScriptBefore { get { return this.requestInfo.ScriptBefore; } set { /* for xml serialization */ } }

        [XmlElement]
        public string ScriptBeforeResult { get; set; }

        [XmlElement]
        public string ScriptAfter { get { return this.requestInfo.ScriptAfter; } set { /* for xml serialization */ } }

        [XmlElement]
        public string ScriptAfterResult { get; set; }
    }
}
