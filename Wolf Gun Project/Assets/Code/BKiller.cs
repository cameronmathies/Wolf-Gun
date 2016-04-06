using UnityEngine;
using System.Collections;

public class BKiller : MonoBehaviour {
	public GameObject Wolfs;
    void OnEnable()
    {
        StartCoroutine(shot());
    }
    IEnumerator shot()
    {
        yield return new WaitForSeconds(1.5f);
      //  Debug.Log("Test");
      gameObject.SetActive(false);
    }
	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Bad") {
			//Destroy(Wolfs);
		}

	}
}
