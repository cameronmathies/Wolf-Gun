using UnityEngine;
using System.Collections;

public class Credits : MonoBehaviour {

	void OnTriggerEnter(Collider other){
		if (other.tag == "Bullet"){
			Application.LoadLevel("Credits");
			//	Debug.Log("Quit");
		}
	}
}
