using UnityEngine;
using System.Collections;

public class WarpPayerToThis : MonoBehaviour {

    public GameObject Player;
    void Awake()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        Player.transform.position = this.transform.position;
    }
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

}
