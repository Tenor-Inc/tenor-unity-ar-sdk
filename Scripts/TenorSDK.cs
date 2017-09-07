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
using System.Threading;
using System.Linq;
using System.ComponentModel;
using System.Collections;

using UnityEngine;
using TenorSDK.Request;

namespace TenorSDK
{	
	public static class TenorAPI
	{

		//
		// NOTE: This example include a restricted, rate limited example key (LIVDSRZULELA) for you to use while evaluating our API. 
		// Before deploying your integration to production, please request your own API key (it's free).
		//

		public static string key = "LIVDSRZULELA"; 	// client key for privileged API access
		private static string TenorAPIUri = "https://api.tenor.com/v1/";

		public delegate void DelegateResponseAnswer(Response inputObject);
		public delegate void DelegateStringAnswer(ResultStringCollection inputObject);
		public delegate void DelegateTagCollectionAnswer(ResultTags inputObject);

		public static void Initialize(string customKey)
		{
			key = customKey;
		}

		// Method to call API End Point: Search https://tenor.com/gifapi#search
		public static IEnumerator Search(SearchRequest request, DelegateResponseAnswer delegateSearch)
		{
			return _apiCallResponse (request.getQueryString (key), delegateSearch);
		}

		// Method to call API End Point: Trending https://tenor.com/gifapi#trending
		public static IEnumerator Trending(TrendingRequest request, DelegateResponseAnswer delegateTrending)
		{
			return _apiCallResponse (request.getQueryString (key), delegateTrending);
		}

		// Method to call API End Point: Tags https://tenor.com/gifapi#tags
		public static IEnumerator Tags(TagRequest request, DelegateTagCollectionAnswer delegateTags)
		{
			return _apiCallTagCollection (request.getQueryString (key), delegateTags);
		}

		// Method to call API End Point: Hourly Trending https://tenor.com/gifapi#hourly-trending
		public static IEnumerator HourlyTrending(HourlyTrendingRequest request, DelegateStringAnswer delegateHourlyTrending)
		{
			return _apiCallStringCollection (request.getQueryString (key), delegateHourlyTrending);
		}

		// Method to call API End Point: Search Suggestions https://tenor.com/gifapi#suggestions
		public static IEnumerator SearchSuggestions(SearchSuggestionsRequest request, DelegateStringAnswer delegateSearchSuggestions)
		{
			return _apiCallStringCollection (request.getQueryString (key), delegateSearchSuggestions);
		}

		// Method to call API End Point: GIFs https://tenor.com/gifapi#gifs
		public static IEnumerator GIFs(GIFsRequest request, DelegateResponseAnswer delegateGIF)
		{
			return _apiCallResponse (request.getQueryString (key), delegateGIF);
		}

		// Method to call API End Point: Register Share https://tenor.com/gifapi#registershare
		public static IEnumerator RegisterShare(RegisterShareRequest request, DelegateStringAnswer delegateRegisterShare)
		{
			return _apiCallStringCollection (request.getQueryString (key), delegateRegisterShare);
		}

		// Method to call API End Point: Auto Complete https://tenor.com/gifapi#autocomplete
		public static IEnumerator AutoComplete(AutoCompleteRequest request, DelegateStringAnswer delegateAutoComplete)
		{
			return _apiCallStringCollection (request.getQueryString (key), delegateAutoComplete);
		}


		/* 
		 * Internal API Calls 
		 * 
		 */ 

		private static IEnumerator _apiCallResponse(string uri, DelegateResponseAnswer delegateSearch) {
			WWW www = new WWW(TenorAPIUri + uri);
			yield return www;
			if (www.error == "" || www.error == null) {
				Response data = JsonUtility.FromJson<Response>(www.text);
				if (delegateSearch != null) {
					
					delegateSearch (data);
				}
			} else {
				throw new Exception(www.error);
			} 			
		}

		private static IEnumerator _apiCallTagCollection(string uri, DelegateTagCollectionAnswer delegateSearch) {
			WWW www = new WWW(TenorAPIUri + uri);
			yield return www;
			if (www.error == "" || www.error == null) {
				ResultTags data = JsonUtility.FromJson<ResultTags>(www.text);
				if (delegateSearch != null) {
					delegateSearch (data);
				}
			} else {
				throw new Exception(www.error);
			} 			
		}

		private static IEnumerator _apiCallStringCollection(string uri, DelegateStringAnswer delegateSearch) {
			WWW www = new WWW(TenorAPIUri + uri);
			yield return www;
			if (www.error == "" || www.error == null) {
				ResultStringCollection data = JsonUtility.FromJson<ResultStringCollection>(www.text);
				if (delegateSearch != null) {
					delegateSearch (data);
				}
			} else {
				throw new Exception(www.error);
			} 			
		}
	}
}