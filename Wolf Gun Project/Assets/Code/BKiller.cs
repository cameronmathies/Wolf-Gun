using UnityEngine;
using System.Collections;

public class BKiller : MonoBehaviour {
	public float Time;
    void OnEnable()
    {
        StartCoroutine(shot());
    }
    IEnumerator shot()
    {
        yield return new WaitForSeconds(Time);
      //  Debug.Log("Test");
      gameObject.SetActive(false);
    }
	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Bad") {
			//Destroy(Wolfs);
		}

	}
}
