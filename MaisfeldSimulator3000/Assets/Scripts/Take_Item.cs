using UnityEngine;
using System.Collections;

public class Take_Item : MonoBehaviour {

    public GameObject Player;
    public int PickDistance = 5;

	public enum Itemtype
	{
		Key,Shotgun
	}

	public Itemtype Item;
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

			if (Item == Itemtype.Shotgun) {
			//TODO Shotgun in inventory
			} else {
				//TODO Key in inventory
			}

        }

        //save object as taken

    }

}
