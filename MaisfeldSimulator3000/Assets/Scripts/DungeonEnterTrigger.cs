using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.SceneManagement;

public class DungeonEnterTrigger : MonoBehaviour {

    public GameObject Player,Interface;
    public bool hasHorse, hasKey, hasShotgun;
    public int SceneIndex = 0;

    void Awake()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
		Interface = GameObject.FindGameObjectWithTag("Interf");
    }
    void Start()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        DontDestroyOnLoad(Player);
		DontDestroyOnLoad(Interface);
        hasHorse = Player.GetComponent<FirstPersonController>().GethasHorse();
        hasKey = Player.GetComponent<FirstPersonController>().GethasKey();
        hasShotgun = Player.GetComponent<FirstPersonController>().GethasShotgun();
        SceneManager.LoadScene(SceneIndex);

    }
}
