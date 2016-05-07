using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EndingText : MonoBehaviour {

	public Text EndingTextfield;

	public string Texttowrite;

	// Use this for initialization
	void Start () {

		
		StartCoroutine (Spell ());

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	IEnumerator Spell()
	{
		for (int i = 0; i < Texttowrite.Length; i++) {
			EndingTextfield.text = EndingTextfield.text+ Texttowrite [i];
			yield return new WaitForSeconds (0.05f);
		}

	}
}
