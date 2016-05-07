using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;

public class EndTriggerScript : MonoBehaviour {

    public GameObject Player;
    public bool hasHorse, hasKey, hasShotgun;

    void OnTriggerEnter(Collider other)
    {
        hasHorse = Player.GetComponent<FirstPersonController>().GethasHorse();
        hasKey = Player.GetComponent<FirstPersonController>().GethasKey();
        hasShotgun = Player.GetComponent<FirstPersonController>().GethasShotgun();
        Destroy(Player);
        SceneManager.LoadScene(0);
        
    }
}
