using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;

public class Take_Item : MonoBehaviour {

    public GameObject Player;
    public int PickDistance = 5;

	public Image Click;

	public enum Itemtype
	{
		Key,Shotgun,Lever
	}

	public Itemtype Item;
	// Use this for initialization
	void Start () {
		Click.IsActive (false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseDown() {


        if (Vector3.Distance(this.transform.position, Player.transform.position) < PickDistance)
        {
            

			if (Item == Itemtype.Shotgun) {
                Player.GetComponent<FirstPersonController>().SethasShotgun(true);
			} else {
                Player.GetComponent<FirstPersonController>().SethasKey(true);
            }
            Destroy(this.gameObject);
			Click.IsActive (false);

        }

        //save object as taken



    }

	void OnTriggerEnter(Collider other)
	{
		Click.IsActive (true);
	}

	void OnTriggerExit(Collider other)
	{
		Click.IsActive (false);
	}

}
