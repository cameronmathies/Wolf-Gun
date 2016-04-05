using UnityEngine;
using System.Collections;

public class spawner : MonoBehaviour {

	public Transform[] spawnLocations;
	public GameObject[] whatToSpawnPrefab;
	public GameObject[] whatToSpawnClone;

	void Start(){
		spawnSomethingAwesomePlease ();
	}
	void spawnSomethingAwesomePlease(){
		whatToSpawnClone [0] = Instantiate (whatToSpawnPrefab[0], spawnLocations[0].transform.position, Quaternion.Euler(0,0,0)) as GameObject;
		whatToSpawnClone [1] = Instantiate (whatToSpawnPrefab[1], spawnLocations[1].transform.position, Quaternion.Euler(0,0,0)) as GameObject;
		whatToSpawnClone [2] = Instantiate (whatToSpawnPrefab[2], spawnLocations[2].transform.position, Quaternion.Euler(0,0,0)) as GameObject;
	}
}