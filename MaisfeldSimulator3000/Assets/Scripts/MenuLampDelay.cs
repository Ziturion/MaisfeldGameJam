using UnityEngine;
using System.Collections;

public class MenuLampDelay : MonoBehaviour {

	public AudioSource Sound;
    public GameObject Lamp;

	// Use this for initialization
	void Start () {

		StartCoroutine (Flicker ());
	
	}
	
	// Update is called once per frame
	void Update () {
    }


	IEnumerator Flicker()
	{
		yield return new WaitForSeconds (2f);
		Sound.Play();
		Lamp.gameObject.SetActive(true);
		yield return new WaitForSeconds (0.1f);
		Sound.Stop();
		Lamp.gameObject.SetActive(false);
		yield return new WaitForSeconds (0.24f);
		Sound.Play();
		Lamp.gameObject.SetActive(true);
		yield return new WaitForSeconds (0.1f);
		Sound.Stop();
		Lamp.gameObject.SetActive(false);
		yield return new WaitForSeconds (0.04f);
		Sound.Play();
		Lamp.gameObject.SetActive(true);


	}




}
