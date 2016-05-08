using UnityEngine;
using System.Collections;

public class FlackerLicht : MonoBehaviour {
    public float MinimumIntensity = 0, MaximumIntensity = 8, Frequence = 8;
    private Light licht;
	public AudioSource audio;

    // Use this for initialization
    void Start () {

        licht = GetComponent<Light>();

}
	
	// Update is called once per frame
	void Update () {

        if (Time.time % Random.Range(1, Frequence) >= 0 && Time.time % Random.Range(1, Frequence) <= 1)
        {
            licht.intensity = Random.Range(MinimumIntensity, MaximumIntensity);
			if(audio!= null)
			audio.volume = licht.intensity / MaximumIntensity;
        }
	
	}
}
