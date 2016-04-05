using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Helth : MonoBehaviour {

	public Slider HealthBar;
	public int Health;
	public Text HealthT;
	public GameObject FireBall;
	public AudioSource Hurt;
	// Use this for initialization
	void Start () {
		Health = 100;
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Bad") {
			//Debug.Log("Die");
			Health -= 6;
			//Destroy();
			AudioSource audio = GetComponent<AudioSource>();
			audio.Play();
			HealthT.text = Health + "";
		}
		if (other.gameObject.tag == "HP +") {
			//Debug.Log("Die");
			Health += 600;
			//Destroy();
		}
			

	}
	// Update is called once per frame
	void Update () {
//		if (HealthBar.name == "Gun Heat")


//		HealthT.text = Health + "";
//		Debug.Log ("Dispay me heath!");
		
		if(Health < 0)
		{
			Application.LoadLevel("Main Menuss");
		}
	}
}
