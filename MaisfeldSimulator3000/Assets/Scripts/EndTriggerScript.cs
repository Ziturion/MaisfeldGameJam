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
    public string Texttowrite;

    void OnTriggerEnter(Collider other)
    {
        hasHorse = Player.GetComponent<FirstPersonController>().GethasHorse();
        hasKey = Player.GetComponent<FirstPersonController>().GethasKey();
        hasShotgun = Player.GetComponent<FirstPersonController>().GethasShotgun();

        Destroy(Player.GetComponent<FirstPersonController>());

        if (hasHorse && hasKey && hasShotgun)
            Texttowrite = "Beste Ende";
        else if (!hasHorse && !hasKey && !hasShotgun)
            Texttowrite = "Biste absolut Tod";
        else if (!hasHorse && hasKey && !hasShotgun)
            Texttowrite = "Biste auch Tod";
        else if (hasHorse && hasKey && !hasShotgun)
            Texttowrite = "Biste auch noch Tod";
        else if (!hasHorse && !hasKey && hasShotgun)
            Texttowrite = "Überlebt aber schlechtes Ende";
        else
        {
            Texttowrite = "Überlebt aber schlechtes Ende";
        }
        EndCanvas.gameObject.SetActive(true);
        StartCoroutine(Spell());
    }
        //SceneManager.LoadScene(0);
        IEnumerator Spell()
            {
            for (int i = 0; i < Texttowrite.Length; i++)
            {
            textfeld.text = textfeld.text + Texttowrite[i];
                yield return new WaitForSeconds(0.05f);
            }

        }
}
