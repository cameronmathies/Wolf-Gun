using UnityEngine;
using System.Collections;

public class Audio : MonoBehaviour {

	public AudioSource Hurt;
	public AudioSource MedKit;
	public AudioSource Lazer;
	public AudioSource Socpe;
	public int MedKitNumber;
	public int SocpeNumber;
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

	void Start(){
		StartCoroutine (SocpeSound ());	
	}

	IEnumerator Med(){
		//Destroy();
		Hurt = GetComponent<AudioSource> ();
		yield return new WaitForSeconds(MedKitNumber); 
		MedKit.Play ();
	}

	IEnumerator SocpeSound(){
		//Destroy();
		//Socpe = GetComponent<AudioSource> ();
		yield return new WaitForSeconds(SocpeNumber); 
		Socpe.Play ();
		StartCoroutine (SocpeSound ());	
	}

}

