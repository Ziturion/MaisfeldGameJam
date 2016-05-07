using UnityEngine;
using System.Collections;

public class MenuLampDelay : MonoBehaviour {

    public GameObject Lamp;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Time.time >= 2)
        {
            Lamp.gameObject.SetActive(true);
        }
        if (Time.time >= 2.1)
        {
            Lamp.gameObject.SetActive(false);
        }
        if (Time.time >= 2.34)
        {
            Lamp.gameObject.SetActive(true);
        }
        if (Time.time >= 2.44)
        {
            Lamp.gameObject.SetActive(false);
        }
        if (Time.time >= 2.48)
        {
            Lamp.gameObject.SetActive(true);
        }
    }
}
