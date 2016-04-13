using UnityEngine;
using System.Collections;

public class EKiller : MonoBehaviour {

	public GameObject Wolfs;
	public float Kill;

//	void OnEnable()
//	{
//	//	StartCoroutine(shot());
//	}
//	IEnumerator shot()
//	{
//	//	yield return new WaitForSeconds(Kill);
//		//  Debug.Log("Test");
//	//	gameObject.SetActive(false);
//	} 
	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Bullet") {
			Destroy(Wolfs);
		}
	}

	void Update(){
		Kill -= Time.deltaTime;
		if (Kill < 0) {
				}
	}
}