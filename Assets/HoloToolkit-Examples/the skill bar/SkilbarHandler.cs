using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkilbarHandler : MonoBehaviour {

	private float threshold = 100f;
	public Slider skillBar;

	void Start()
	{
		print ("value : " + skillBar.value);
	}
		
	void Update()
	{
		if (Input.GetKey (KeyCode.Space))
			skillBar.value = 1.0f;

		if (Input.GetKeyDown (KeyCode.P)) {
			AudioSource aaud = this.GetComponent<AudioSource> ();

			print ("pitch :" + aaud.pitch);
		}
	}
}
