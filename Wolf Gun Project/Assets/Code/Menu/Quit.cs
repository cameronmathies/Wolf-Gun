using UnityEngine;
using System.Collections;

public class Quit : MonoBehaviour {

	void OnTriggerEnter(Collider other){
		if (other.tag == "Bullet"){
			Application.Quit();
		//	Debug.Log("Quit");
		}
		if (other.tag == "Player") {
			Application.Quit();
			//	Debug.Log("Quit");
		}
}
}
