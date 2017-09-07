using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using TenorSDK;
using TenorSDK.Request;

public class SearchSuggestionsExample : MonoBehaviour {

	public GalleryStrings resultStrings; 
	public InputField inputTag;
	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {

	}

	// Search Suggestions
	public void SearchSuggestionsTenorGIF() {

		// Initialize SDK
		TenorAPI.Initialize ("LIVDSRZULELA");

		// Prepare Request data
		SearchSuggestionsRequest request = new SearchSuggestionsRequest ();
		request.limit = "10";
		request.tag = inputTag.text;

		// Call Coroutine to not freeze
		StartCoroutine(TenorAPI.SearchSuggestions(request, ProcessAnswers));

	}

	void ProcessAnswers(ResultStringCollection data) {
		resultStrings.data = data.results;
		resultStrings.showTags ();
	}

}
