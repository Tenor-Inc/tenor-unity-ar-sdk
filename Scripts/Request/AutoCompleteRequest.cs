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

namespace TenorSDK.Request
{	
	public class AutoCompleteRequest : RequestGET
	{
		public string allterms; 	// fetch all results; available for privileged keys only, overrides limit.
		public string key; 			// client key for privileged API access
		public string limit; 		// fetch up to a specified number of results (max: 50).
		public string q; 			// partially typed search term
		public string locale; 		// specify default language to interpret search string; xx is ISO 639-1 language code, _YY (optional) is 2-letter ISO 3166-1 country code

		private string Uri = "/autocomplete";

		public AutoCompleteRequest() {
		}

		public string getQueryString(string key) {
			return Uri + "?key=" + key + generateQueryString ();
		}

	}
}