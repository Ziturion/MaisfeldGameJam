using UnityEngine;
using System.Collections;

public class Lever : MonoBehaviour
{
    public GameObject Player;
    public int PickDistance = 5;
    public bool Triggered = false;

    void OnMouseDown()
    {
        TriggerLogic();
    }
    public void TriggerLogic()
    {
        if (Vector3.Distance(this.transform.position, Player.transform.position) < PickDistance)
        {
            this.transform.Rotate(this.transform.localRotation.x, this.transform.localRotation.y, this.transform.localRotation.z + 180, Space.Self);
            if (Triggered)
            {
                Triggered = false;
            }
            else
            {

                Triggered = true;
                Player.GetComponent<Leverscript>().PressedLever();
            }
        }
    }
}
