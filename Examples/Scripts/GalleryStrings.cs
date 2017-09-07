using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using TenorSDK;
using TenorSDK.Request;

public class GalleryStrings : MonoBehaviour {

	public string[] data;
	public GameObject container;
	public float padding = 10.0f;
	private float elementWidth;
	private float elementHeight;

	// Use this for initialization
	void Start () {		
	}

	// Update is called once per frame
	void Update () {

	}

	public void showTags() {

		float actualHeight = padding * -1;

		// Get TextTagExampe
		GameObject textTagExample = GameObject.Find ("TextTagExample");

		// Calculate one time width and height
		RectTransform textTagRT = textTagExample.GetComponent (typeof (RectTransform)) as RectTransform;
		elementWidth = textTagRT.rect.width;
		elementHeight = textTagRT.rect.height;

		// Remove previous elements
		foreach (Transform child in container.transform) {
			GameObject.Destroy(child.gameObject);
		}

		for (int i = 0; i < data.Length; i++) {
			
			// Instatiate New Game Object and store data to show
			GameObject tenorGO = Instantiate (textTagExample, container.transform);
			Text text = tenorGO.GetComponent<Text> ();
			text.text = "#" + i + " " + data [i];

			// Update Scroll position
			tenorGO.transform.localPosition = new Vector3 (padding, actualHeight, 0); 
			actualHeight -= (elementHeight) + padding;

			// Update Container height
			RectTransform rt = container.GetComponent (typeof (RectTransform)) as RectTransform;
			rt.sizeDelta = new Vector2 (elementWidth + 2 * padding, actualHeight * -1);		

		}
	}
}
