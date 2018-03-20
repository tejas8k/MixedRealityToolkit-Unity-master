using UnityEngine;

using System.Collections;

public class RaycastExample : MonoBehaviour
{
	public GameObject Startbutton;
	public GameObject Warning;
	private GameObject refWarning;
	public GameObject Gameobjectw;

	void Start()
	{
		refWarning = Warning;
	}
	void Update()
	{
		RaycastHit hit;

		if (Physics.Raycast (transform.position, transform.TransformDirection(Vector3.forward), out hit, 100000)) {
			//print ("hit :" + hit.collider.gameObject);
			if (hit.collider.gameObject.tag != "Eye" && Startbutton.activeInHierarchy == false&& Gameobjectw.activeInHierarchy==true) {
				refWarning.SetActive (true);


			}
		

				//StartCoroutine (DisableDialog ());
				//print ("Found an object - distance: " + hit.collider.gameObject.tag);
			 
			else {
				Warning.SetActive (false);
			}
		}
			//StartCoroutine (DisableDialog ());
			//print ("Found an object - distance: " + hit.collider.gameObject.tag);
		}

	}
		
	
//	IEnumerator DisableDialog()
//	{
//		yield return new WaitForSeconds (3f);
//		refWarning.SetActive (false);
//	}

