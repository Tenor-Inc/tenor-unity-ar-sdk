using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using TenorSDK;
using TenorSDK.Request;

public class GalleryGIFs : MonoBehaviour {

	public Result[] data;
	public GameObject container;
	public float padding = 20.0f;
	public float elementWidth = 400.0f;

	// Use this for initialization
	void Start () {		
	}

	// Update is called once per frame
	void Update () {

	}

	public void LoadAssets() {

		float actualHeight = padding * -1;

		// Remove all child from previous display
		foreach (Transform child in container.transform) {
			GameObject.Destroy(child.gameObject);
		}	

		// Create all elements
		for (int i = 0; i < data.Length; i++) {

			Media media = data [i].media [0].mediumgif;
			var ratio = elementWidth / media.dims [0];

			// Instatiate New Game Object
			GameObject tenorGO = Instantiate (GameObject.Find ("GIFContainer"), container.transform);

			// Look for the GIF asset
			UniGifImage imageGIF = tenorGO.GetComponent<UniGifImage> ();
			StartCoroutine(imageGIF.SetGifFromUrlCoroutine(media.url));

			// Update Scroll position
			tenorGO.transform.localPosition = new Vector3 (padding, actualHeight, 0); 
			actualHeight -= (media.dims [1] * ratio) + padding;	

		}

		// Adjust Container Height
		RectTransform rt = container.GetComponent (typeof (RectTransform)) as RectTransform;
		rt.sizeDelta = new Vector2 (elementWidth + 2 * padding, actualHeight * -1);		
	}
}
