using UnityEngine;
using System.Collections;

public class gameobjects : MonoBehaviour {

	// Use this for initialization
	public int enemiesLeft = 1;
	bool killedAllEnemies = false;
	public float Kill;
	public GameObject Wolfs;
	void Start () {
		enemiesLeft = 10; // or whatever;
		
	}
	
	// Update is called once per frame
	void Update () {
		GameObject[] enemies = GameObject.FindGameObjectsWithTag("Bad");
		enemiesLeft = enemies.Length;
		if(Input.GetKeyDown(KeyCode.A))
		{
			enemiesLeft --;
		}
		if(enemiesLeft == 0)
		{
			endGame();
		}

			Kill -= Time.deltaTime;
			if (Kill < 0) {
			Destroy(Wolfs);
			}
	}
	
	void endGame()
	{
		killedAllEnemies = true;
		Application.LoadLevel("Credits");
	}
	
	void OnGUI()
	{
		if(killedAllEnemies)
		{
			GUI.Label(new Rect (0,0,200,20),"all gone");
		}
		else
		{
			GUI.Label(new Rect (0,0,200,20),"Enemies Remaining : " + enemiesLeft);
		}
	}
}
