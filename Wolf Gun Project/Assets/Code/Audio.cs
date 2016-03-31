using UnityEngine;
using System.Collections;

public class Audio : MonoBehaviour {

	public AudioSource Hurt;

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Bad") {
			//Debug.Log("Die");

			//Destroy();
			 Hurt = GetComponent<AudioSource> ();
			Hurt.Play ();
			
		}
	}
}
