using UnityEngine;
using System.Collections;

public class FlackerLicht : MonoBehaviour {
    private Light licht;
    // Use this for initialization
    void Start () {

        licht = GetComponent<Light>();
}
	
	// Update is called once per frame
	void Update () {

        if (Time.time % Random.Range(1, 3) == 0)
        {
            licht.intensity = Random.Range(2, 7);
        }
	
	}
}
