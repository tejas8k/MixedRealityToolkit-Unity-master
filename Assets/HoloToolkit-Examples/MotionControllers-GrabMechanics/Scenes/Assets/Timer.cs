using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
	private float timeLeft = 300f;
	private float secondsLeft = 60f;
	private float minutesLeft = 4f;
	private float counter = 0;

	public Text seconds;
	public Text minutes;

//	private void OnGUI(){
//		if( secondsLeft > 0)
//			GUILayout.Label("Countdown seconds remaining = " + (int)minutesLeft	+ " : " + (int)secondsLeft + "----" + (int)counter);
//		else
//			GUILayout.Label("Countdown has finished");
//
//
//	}

	private void Update(){
		if (timeLeft > 0) {
			timeLeft -= Time.deltaTime;
			secondsLeft -= Time.deltaTime;

			seconds.text = (Mathf.Round (secondsLeft)).ToString ();
			minutes.text = minutesLeft.ToString ();
			counter += Time.deltaTime;
			if (counter >= 60) {
				minutesLeft -= 1;
				minutes.text = minutesLeft.ToString ();
				secondsLeft = 60;
				counter = 0;
			}
		}
	}
}