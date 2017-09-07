using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TenorSDK;
using TenorSDK.Request;

public class TrendingExample : MonoBehaviour {

	public GalleryGIFs resultGIFs; 

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	// Search Trending GIFs
	public void TrendingTenorGIF() {

		// Initialize SDK
		TenorAPI.Initialize ("LIVDSRZULELA");

		// Prepare Request data
		TrendingRequest request = new TrendingRequest ();
		request.pos = "";
		request.limit = "5";

		// Call Coroutine to not freeze
		StartCoroutine(TenorAPI.Trending(request, ProcessAnswers));

	}

	void ProcessAnswers(Response data) {
		resultGIFs.data = data.results;
		resultGIFs.LoadAssets ();
	}
				
}
