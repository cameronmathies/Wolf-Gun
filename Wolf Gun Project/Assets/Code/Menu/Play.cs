using UnityEngine;
using System.Collections;

public class Play : MonoBehaviour {

	void OnTriggerEnter(Collider other){
		if (other.tag == "Bullet"){
			Application.LoadLevel("Mars");
			//	Debug.Log("Quit");
		}s

		void enter(){
		
		if(Input.GetButtonDown("Q")){
			if (other.tag == "Bullet"){
				Application.LoadLevel("Mars");
				//	Debug.Log("Quit");
			}
	}
}
}
}s
