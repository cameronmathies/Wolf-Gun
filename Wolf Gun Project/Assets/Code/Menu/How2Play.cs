using UnityEngine;
using System.Collections;

public class How2Play : MonoBehaviour {

	void OnTriggerEnter(Collider other){
		if (other.tag == "Bullet"){
			Application.LoadLevel("How2Play");
			//	Debug.Log("Quit");
		}
	}
}
