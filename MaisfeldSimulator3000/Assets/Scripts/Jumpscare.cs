using UnityEngine;
using System.Collections;

public class Jumpscare : MonoBehaviour {

	public GameObject Player;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){


		if (other.GetComponent<GameObject> () == Player) {
			//TODO Was soll passieren
		}

	}
}
