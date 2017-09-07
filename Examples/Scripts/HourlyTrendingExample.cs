using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TenorSDK;
using TenorSDK.Request;

public class HourlyTrendingExample : MonoBehaviour {

	public GalleryStrings resultStrings; 

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {

	}
		
	// Search Hourly Trending GIFs
	public void HourlyTrendingTenorGIF() {

		// Initialize SDK
		TenorAPI.Initialize ("LIVDSRZULELA");

		// Prepare Request data
		HourlyTrendingRequest request = new HourlyTrendingRequest ();
		request.pos = "";

		// Call Coroutine to not freeze
		StartCoroutine(TenorAPI.HourlyTrending(request, ProcessAnswers));

	}

	void ProcessAnswers(ResultStringCollection data) {
		resultStrings.data = data.results;
		resultStrings.showTags ();
	}

}
