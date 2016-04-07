using UnityEngine;
using System.Collections;

public class EKiller : MonoBehaviour {

	public GameObject Wolfs;

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Bullet") {
			Destroy(Wolfs);
		}
	}
}