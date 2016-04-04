using UnityEngine;
using System.Collections;

public class Audio : MonoBehaviour {

	public AudioSource Hurt;
	public AudioSource MedKit;
	public AudioSource Lazer;
	public int MedKitNumber;
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Bad") {
			//Debug.Log("Die");

			//Destroy();
			 Hurt = GetComponent<AudioSource> ();
			Hurt.Play ();
			
		}
		if (other.gameObject.tag == "HP +") {
			//Debug.Log("Die");
			StartCoroutine(Med());
		}
		if (Input.GetButtonDown("Fire1")){
			//Debug.Log("Die");
			Hurt = GetComponent<AudioSource> ();
			Lazer.Play ();
		}
		//Destroy();s

		
	}


	IEnumerator Med(){
		//Destroy();
		Hurt = GetComponent<AudioSource> ();
		yield return new WaitForSeconds(MedKitNumber); 
		MedKit.Play ();
	}

}

