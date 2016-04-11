using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour {

	public AudioSource NamesRead;
	void OnTriggerEnter(Collider other){
		if (other.tag == "Bullet"){
			Application.LoadLevel("Credits");
			//	Debug.Log("Quit");
		}
	}

	void Start (){
		if (SceneManager.GetActiveScene().name == "Credits")
		{
			StartCoroutine (Names ());	
		}
	}

	IEnumerator Names(){
		yield return new WaitForSeconds(34); 
		Application.LoadLevel("Main Menu");

		
		
	}
}
