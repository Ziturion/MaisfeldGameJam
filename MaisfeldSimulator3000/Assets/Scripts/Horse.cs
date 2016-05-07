using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class Horse : MonoBehaviour {

    public GameObject Player;
    public int PickDistance = 5;

    void OnMouseDown()
    {


        if (Vector3.Distance(this.transform.position, Player.transform.position) < PickDistance)
        {
            Player.GetComponent<FirstPersonController>().SethasHorse(true);
            Destroy(this.gameObject);
        }

        //save object as taken

    }
}
