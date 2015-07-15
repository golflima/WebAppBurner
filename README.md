# WebAppBurner

WebAppBurner is a free, portable, open-source, and easy-to-use benchmarking tool for web based applications and web servers.

## Supported commands for "ScriptBefore" and "ScriptAfter"
* __Burn__
	- Activates the _Burning_ mode : tells to WebAppBurner to send the request, and ignore the result. Usefull for load testing. 
* __Burnout__
	- Deactivate the _Burning_ mode : tells to WebAppBurner to wait for the result of every request. This is the default behavior.
* __Response__
	- Gets the full response of an Http request. If used in _ScriptAfter_ it will displays the current response, and in _ScriptBefore_ it will displays the previous response.
* __Url__
	- Gets the url to call.
* __Url__ _"url"_
	- Sets the url to call with the given _url_ value.
* __PostData__
	- Gets the raw post data to send with the request.
* __PostData__ _"postData"_
	- Sets Gets the raw post data to send with the request with the given _postData_ value.
* __Timeout__
	- Gets the timeout used for executing requests, in milliseconds (ms).
* __Timeout__ _"timeout"_
	- Sets the timeout used for executing requests, in milliseconds (ms), with given _timeout_ value.
* __AddCookie__ _"url"_ _"name"_ _"value"_ _"path"_
	- Adds a cookie in the web client used to execute requests. The cookie will be placed on given _url_, named with given _name_, have given _value_, and set to given _path_.
* __SetCookies__ _"url"_ _"cookieHeader"_
	- Sets the cookie header to given _cookieHeader_ value for the given _url_.
* __RemoveCookie__ _"url"_ _"name"_
	- Removes cookies associated to given _url_ with the given _name_, for every paths.
* __RemoveCookie__ _"url"_ _"name"_ _"path"_
	- Removes cookies associated to given _url_ with the given _name_, for given _path_.
* __ClearCookies__ _"url"_
	- Clears all cookies for the given _url_.

## Licence

GL.WebAppBurner, Benchmarking tool for web applications.
Copyright (C) 2015, Jérémy WALTHER (jeremy.walther@golflima.net)

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program.  If not, see <http://www.gnu.org/licenses/>.


This program uses the following copyrighted materials :
* GL.MetaN.ReflectionConsole
	- copyright : Jérémy WALTHER, distributed under GNU LGPL v3
	- website : http://sourceforge.net/projects/metan
* Google Material design icons
	- copyright : Google, distributed under CC-BY 4.0
	- website : http://www.google.com/design/spec/style/icons.html
* TaskbarProgress
	- copyright : WholsRich, distributed under CC-BY-SA 3.0
	- website : http://stackoverflow.com/questions/1295890/windows-7-progress-bar-in-taskbar-in-c/24187171#24187171
