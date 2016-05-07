using UnityEngine;
using System.Collections;

public class TriggerPlay : MonoBehaviour {

	public AudioClip ClipToPlay;

	public AudioSource audio;

	void OnTriggerEnter (Collider other)
	{
		StartCoroutine (FadeIn ());
	}

	IEnumerator FadeIn()
	{
		audio.clip = ClipToPlay;

		audio.volume = 0.1f;
		while (audio.volume < 1) {
			audio.volume = audio.volume*1.4f;
			yield return new WaitForSeconds (0.1f);
		}
		while (audio.volume > 0) {
			audio.volume = audio.volume*0.95f;
			yield return new WaitForSeconds (0.1f);
		}
		Destroy (this);

	}
		


}
