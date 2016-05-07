using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

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
                Player.GetComponent<FirstPersonController>().SethasShotgun(true);
			} else {
                Player.GetComponent<FirstPersonController>().SethasKey(true);
            }

        }

        //save object as taken

    }

}
