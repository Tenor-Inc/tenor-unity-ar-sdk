using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TenorSDK;
using TenorSDK.Request;

public class TagsExample : MonoBehaviour {

	public GalleryTags resultTags; 

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {

	}

	// Search Tags
	public void TagsTenorGIF() {

		// Initialize SDK
		TenorAPI.Initialize ("LIVDSRZULELA");

		// Prepare Request data
		TagRequest request = new TagRequest ();
		request.type = "featured";

		// Call Coroutine to not freeze
		StartCoroutine(TenorAPI.Tags(request, ProcessAnswers));
	}

	void ProcessAnswers(ResultTags data) {
		resultTags.data = data.tags;
		resultTags.LoadAssets ();
	}

}
