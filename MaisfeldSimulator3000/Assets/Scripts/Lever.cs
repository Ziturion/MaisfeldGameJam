using UnityEngine;
using System.Collections;

public class Lever : MonoBehaviour
{
    public GameObject Player;
    public int PickDistance = 5;
    public bool Triggered = false;
    public GameObject LeverScript;
    public GameObject LeverObject;

    void OnMouseDown()
    {
        TriggerLogic();
    }
    void Awake()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }
    public void TriggerLogic()
    {
        if (Vector3.Distance(this.transform.position, Player.transform.position) < PickDistance)
        {
            
            if (Triggered)
            {
                Triggered = false;
                LeverObject.transform.position = new Vector3(0, 0, (float)-64.133);
            }
            else
            {
                LeverObject.transform.position = new Vector3(0, 0, (float)-64.233);
                Triggered = true;
                LeverScript.GetComponent<Leverscript>().PressedLever();
            }
        }
    }
}
