using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;

public class EndTriggerScript : MonoBehaviour {

    public GameObject Player;
    public Canvas EndCanvas;
    public Text textfeld;
    public bool hasHorse, hasKey, hasShotgun;

    void OnTriggerEnter(Collider other)
    {
        hasHorse = Player.GetComponent<FirstPersonController>().GethasHorse();
        hasKey = Player.GetComponent<FirstPersonController>().GethasKey();
        hasShotgun = Player.GetComponent<FirstPersonController>().GethasShotgun();

        Destroy(Player.GetComponent<FirstPersonController>());

        if (hasHorse && hasKey && hasShotgun)
            textfeld.text = "Beste Ende";
        else if (!hasHorse && !hasKey && !hasShotgun)
            textfeld.text = "Biste absolut Tod";
        else if (!hasHorse && hasKey && !hasShotgun)
            textfeld.text = "Biste auch Tod";
        else if (hasHorse && hasKey && !hasShotgun)
            textfeld.text = "Biste auch noch Tod";
        else if (!hasHorse && !hasKey && hasShotgun)
            textfeld.text = "Überlebt aber schlechtes Ende";
        else
        {
            EndCanvas.GetComponent<Text>().text = "Überlebt aber schlechtes Ende";
        }
        EndCanvas.gameObject.SetActive(true);
        //SceneManager.LoadScene(0);
        
    }
}
