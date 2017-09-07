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
	public class RegisterShareRequest : RequestGET
	{
		public string id; 			// id of GIF shared
		public string key; 			// client key for privileged API access
		public string scount; 		// number of prior shares
		public string tag; 			// original tag or search string triggering the share

		private string Uri = "/registershare?";

		public RegisterShareRequest() {
		}

		public string getQueryString(string key) {
			return Uri + "key=" + key + generateQueryString ();
		}

	}
}