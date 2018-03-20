// Add this script to a GameObject. The Start() function fetches an
// image from the documentation site.  It is then applied as the
// texture on the GameObject.

using UnityEngine;
using System.Collections;


public class ExampleClass : MonoBehaviour
{
	public GameObject left;
	public GameObject Right;
	public string url = "D:\\Images";
	int i = 1;
	public void OnRightClick()
	{if (i <= 5) {
			url = "D:\\Images" + "\\" + i + ".png";
			print ("url :" + url);
			i++;
			StartCoroutine (LoadImage ());
		}
	}
	void Start()
	{
		StartCoroutine (LoadImage ());
	}
	public void OnLeftClick()
	{
		if (i > 0) {
			url = "D:\\Images" + "\\" + i + ".png";
			print ("url2 :" + url);
			i--;
			StartCoroutine (LoadImage ());
		}
	}

	IEnumerator LoadImage()
	{
		Texture2D tex;
		tex = new Texture2D(4, 4, TextureFormat.DXT1, false);
		using (WWW www = new WWW(url))
		{
			yield return www;
			www.LoadImageIntoTexture(tex);
			GetComponent<Renderer>().material.mainTexture = tex;
		}
	}
}