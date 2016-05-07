using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;

public class InterfaceHandleScript : MonoBehaviour {

    public GameObject Player;

    public enum UIType
    {
        Shotgun,Key,Horse
    }

    public UIType MyUIType;

    void Awake()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        switch (MyUIType)
        {
            case UIType.Shotgun:
                this.GetComponent<Image>().enabled = Player.GetComponent<FirstPersonController>().GethasShotgun();
                break;
            case UIType.Key:
                this.GetComponent<Image>().enabled = Player.GetComponent<FirstPersonController>().GethasKey();
                break;
            case UIType.Horse:
                this.GetComponent<Image>().enabled = Player.GetComponent<FirstPersonController>().GethasHorse();
                break;
        }
        
	
	}
}
