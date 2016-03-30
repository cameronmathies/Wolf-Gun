using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Helth : MonoBehaviour {

	public Slider HealthBar;
	public int Health;
	public Text HealthT;
	public GameObject FireBall;
	
	// Use this for initialization
	void Start () {
		Health = 100;
	}
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Bad")
			//Debug.Log("Die");
			Health -= 6;
			//Destroy();
			

	}
	// Update is called once per frame
	void Update () {
		if (HealthBar.name == "Health")
		{
			HealthBar.value = Health;
		}
		HealthT.text = Health + "";
		
		if(Health < 0)
		{
			Application.LoadLevel("Main Menuss");
		}
	}
}
