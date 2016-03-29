using UnityEngine;
using System.Collections;

public class Quit : MonoBehaviour {

	void OnTriggerEnter(){
		if (GetComponent<Collider>().tag == "Ball"){
			Application.Quit();
		}
}
}
