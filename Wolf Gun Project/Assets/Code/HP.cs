using UnityEngine;
using System.Collections;

public class HP : MonoBehaviour {

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player") {
			Destroy (gameObject);
		}
	}
		}
		

