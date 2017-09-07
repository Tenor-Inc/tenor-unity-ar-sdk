//
// Tenor Unity SDK - Unity libraries for Tenor GIF
// =================================================
//
// Copyright (C) 2017 by Dift.co (http://dift.co)
// https://www.tenor.com
//
// ***********************************************************************************************************************
//
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on
// an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the
// specific language governing permissions and limitations under the License.
//
// ***********************************************************************************************************************


using System;
using UnityEngine;
using System.Threading;
using System.Linq;
using System.ComponentModel;
using System.Collections;
using System.Reflection;

namespace TenorSDK.Request
{	
	public class SearchRequest : RequestGET
	{
		public string country; 		// specify default country for regional content; format is 2-letter ISO 3166-1 country code
		public string key; 			// client key for privileged API access
		public string limit; 			// fetch up to a specified number of results (max: 50).
		public string locale; 		// specify default language to interpret search string; xx is ISO 639-1 language code, _YY (optional) is 2-letter ISO 3166-1 country code
		public string pos; 			// get results starting at position "value". Use a non-zero "next" value returned by API results to get the next set of results. pos is not an index and may be an integer, float, or string
		public string safesearch; 	// (values:off|moderate|strict) specify the content safety filter level
		public string q; 			// a tag or search string

		private string Uri = "/search";

		public SearchRequest() {
		}

		public string getQueryString(string key) {
			return Uri + "?key=" + key + generateQueryString ();
		}
	}
}