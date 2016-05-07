using UnityEngine;
using System.Collections;

public class Leverscript : MonoBehaviour {

    public GameObject Lever1, Lever2, Lever3, Door;

    public bool FirstRightAnswer = false, SecondRightAnswer = false, ThirdRightAnswer = false;

    public void PressedLever()
    {
        if (SecondRightAnswer && Lever3.GetComponent<Lever>().Triggered)
        {
            Door.gameObject.SetActive(false);
            Lever1.GetComponent<Lever>().TriggerLogic();
            Lever2.GetComponent<Lever>().TriggerLogic();
            Lever3.GetComponent<Lever>().TriggerLogic();
        }
        else
        {
            ThirdRightAnswer = false;
        }
        if (FirstRightAnswer && Lever2.GetComponent<Lever>().Triggered && !Lever3.GetComponent<Lever>().Triggered)
        {
            SecondRightAnswer = true;
        }
        else
        {
            SecondRightAnswer = false;
        }
        if (Lever1.GetComponent<Lever>().Triggered && !Lever2.GetComponent<Lever>().Triggered && !Lever3.GetComponent<Lever>().Triggered)
        {
            FirstRightAnswer = true;
        }
        else
        {
            FirstRightAnswer = false;
        }
    }
}
