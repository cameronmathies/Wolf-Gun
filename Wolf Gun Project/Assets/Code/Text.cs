using UnityEngine;
using System.Collections;

public class Text : MonoBehaviour {

	 string myString = " Programmer \n Cameron Mathies \n \n Artists \n Amanda White \n Alec Koncinsky \n Noah Pottle  ";
	public AudioSource Typing;
	
	// Use this for initialization
	void Start () {
		StartCoroutine("AutoType");
	}
	
	// Update is called once per frame
	IEnumerator AutoType () {
		Keys (); 
		foreach(char letter in myString.ToCharArray()){
			GetComponent<GUIText>().text += letter; //for unity 5x
			// guiText.text += letter;  // for unity 4x
			yield return new WaitForSeconds(0.3f);
		}
	}

	void Keys(){
		Typing = GetComponent<AudioSource> ();
		Typing.Play ();
		yield return new WaitForSeconds(0.3f);
		Keys ();
	}
}
