using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class myTimer : MonoBehaviour {

	public float myCoolTimer;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		myCoolTimer -= Time.deltaTime;
	}
}
