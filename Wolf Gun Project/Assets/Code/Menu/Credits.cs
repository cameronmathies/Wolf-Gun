using UnityEngine;
using System.Collections;

public class Credits : MonoBehaviour {

	public AudioSource NamesRead;
	void OnTriggerEnter(Collider other){
		if (other.tag == "Bullet"){
			Application.LoadLevel("Credits");
			//	Debug.Log("Quit");
		}
	}

	void NameScene (){

	}

	IEnumerator Names(){
		yield return new WaitForSeconds(34); 
		Application.LoadLevel("Main Menu");

		
		
	}
}
