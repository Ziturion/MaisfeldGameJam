using UnityEngine;
using System.Collections;

public class Jumpscare : MonoBehaviour {

	public GameObject Player;
    public bool Konsistent = true;
    public float DurationWhenNotKonsistent = 0.2f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){

        this.GetComponent<MeshRenderer>().enabled = true;
            if (!Konsistent)
            {
                StartCoroutine(Deactivate());
            }
	}

    IEnumerator Deactivate()
    {
        yield return new WaitForSeconds(DurationWhenNotKonsistent);
        this.gameObject.SetActive(false);
    }
}
