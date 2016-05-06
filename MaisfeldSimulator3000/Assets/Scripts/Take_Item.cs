using UnityEngine;
using System.Collections;

public class Take_Item : MonoBehaviour {

    public GameObject Player;
    public int PickDistance = 5;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseDown() {


        if (Vector3.Distance(this.transform.position, Player.transform.position) < PickDistance)
        {
            Destroy(this.gameObject);
        }

        //save object as taken

    }

}
