using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.SceneManagement;

public class DungeonEnterTrigger : MonoBehaviour {

    public GameObject Player;
    public bool hasHorse, hasKey, hasShotgun;



    void OnTriggerEnter(Collider other)
    {
        DontDestroyOnLoad(Player);
        hasHorse = Player.GetComponent<FirstPersonController>().GethasHorse();
        hasKey = Player.GetComponent<FirstPersonController>().GethasKey();
        hasShotgun = Player.GetComponent<FirstPersonController>().GethasShotgun();
        SceneManager.LoadScene(0);

    }
}
