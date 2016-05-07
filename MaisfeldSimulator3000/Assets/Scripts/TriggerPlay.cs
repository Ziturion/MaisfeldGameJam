using UnityEngine;
using System.Collections;

public class TriggerPlay : MonoBehaviour {

	public AudioClip ClipToPlay;

	public AudioSource audio;

    private bool hastriggered = false;

	void OnTriggerEnter (Collider other)
	{
        if(!hastriggered)
		    StartCoroutine (FadeIn ());
        hastriggered = true;
	}

	IEnumerator FadeIn()
	{
		audio.clip = ClipToPlay;
		audio.volume = 0.5f;
	    while (audio.volume < 1) {
			audio.volume = audio.volume*1.4f;
			yield return new WaitForSeconds (0.1f);
		}
		while (audio.volume > 0) {
			audio.volume = audio.volume*0.90f;
			yield return new WaitForSeconds (0.1f);
		}
        yield return new WaitForSeconds(4);
		//Destroy (this);

	}
		


}
