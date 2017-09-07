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
	public class RequestGET
	{

		public string generateQueryString() {

			string response = "";
			// Loop all fields
			FieldInfo[] properties = this.GetType().GetFields();
			foreach (FieldInfo property in properties)
			{
				if (property.GetValue (this) != null) {					
					string value = property.GetValue (this).ToString ();
					if (!String.IsNullOrEmpty (value)) {
						response += "&" + property.Name + "=" + value;
					}
				}
			}
			return response;
		}
	}
}