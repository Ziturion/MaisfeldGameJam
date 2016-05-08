using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BlendInItemText : MonoBehaviour {


    bool hasWatched = false;
    public enum TextItemType{
        Bogen,Tomahawk,Federhut,Friedenspfeife
    }
    public TextItemType ThisItem;
    public Text Textfeld;
    public float Duration = 3;
	// Use this for initialization
    void Awake()
    {
        Textfeld = GameObject.FindGameObjectWithTag("ItemText").GetComponent<Text>();
    }

	void Start () {
        Textfeld.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        if (!hasWatched)
        {
            StartCoroutine(BlendInText());
        }
    }
    string GetItemDescription()
    {
        switch (ThisItem)
        {
            case TextItemType.Bogen:
                return "Das ist der Bogen von Nuila der Ungezähmten, kein Mann konnte sie bändigen, was für eine böse Kraft ist hier am Werk, dass ihr Bogen verloren ging?";
            case TextItemType.Federhut:
                return "Der Federhut des Häuptlings! Er muss hier irgendwo sein, hoffentlich lebt “Großer Büffel” noch. Er muss genau wie ich bei dem Überfall hier gefangen worden sein. Vielleicht ist er ja entkommen, er ist der größte Krieger des Stammes!";
            case TextItemType.Friedenspfeife:
                return "Der alte Schamane ist schon länger verschwunden, kann es sein, dass er auf diesem Hof verschwunden ist? Haben sie ihn hier gefangen genommen? Ich bitte die Geister darum, dass “Weißer Biber” noch lebt. Was geht hier nur vor sich?";
            case TextItemType.Tomahawk:
                return "Wieso ist das Tomahawk von meinem Bruder “Der mit dem Huf stampft” hier? Haben sie ihn etwa auch gefangen? Wer sind diese Wesen? Hat unser Stamm das Wohlwollen der Geister verloren? Dies sind böse Omen auf eine dunkle Zeit.";
        }
        return "";
    }

    IEnumerator BlendInText()
    {
        Textfeld.text = GetItemDescription();
        Textfeld.enabled = true;
        yield return new WaitForSeconds(Duration);
        Textfeld.enabled = false;
        hasWatched = true;
    }
}
