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
    [Serializable]
    public class TestRequestInfo
    {
        /// <summary>
        /// Gets or sets the name of the request.
        /// </summary>
        public string Name {get;set;}
        
        /// <summary>
        /// Gets or sets the URL to test.
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets the POST data to send with the request.
        /// </summary>
        public string PostData { get; set; }

        /// <summary>
        /// Gets or sets a REGEX used to validate the result of the request.
        /// </summary>
        public string ResultValidation { get; set; }

        public string ResultDataExtract { get; set; }

        public string ResultDataSeparator { get; set; }

        public string ScriptBefore { get; set; }

        public string ScriptAfter { get; set; }
    }
}
