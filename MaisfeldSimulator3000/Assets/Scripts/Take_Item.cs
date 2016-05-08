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
    void Awake()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
		Click = GameObject.FindGameObjectWithTag("Click").GetComponent<Image>();
    }
    void Start () {
		Click.enabled=false;
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
			Click.enabled =false;

        }

        //save object as taken



    }

	void OnTriggerEnter(Collider other)
	{
		Click.enabled =true;
	}

	void OnTriggerExit(Collider other)
	{
		Click.enabled=false;
	}

}
