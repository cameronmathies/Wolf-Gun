using UnityEngine;
using System.Collections;

public class Text : MonoBehaviour {

	string myString = "This is a auto typing text...";
	
	// Use this for initialization
	void Start () {
		StartCoroutine("AutoType");
	}
	
	// Update is called once per frame
	IEnumerator AutoType () {
		foreach(char letter in myString.ToCharArray()){
			GetComponent<GUIText>().text += letter; //for unity 5x
			// guiText.text += letter;  // for unity 4x
			yield return new WaitForSeconds(0.3f);
		}
	}
}
