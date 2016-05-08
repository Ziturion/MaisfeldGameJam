using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BlendInItemText : MonoBehaviour {


    bool hasWatched = false;
    public enum TextItemType{
        Bogen,Tomahawk,Federhut,Friedenspfeife,Anfang, Pferd, Keller, Schalter, Kultraum
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
            case TextItemType.Anfang:
                return "Uff… Mir schmerzt alles, wo bin ich? Wo ist mein Pferd? Ich muss zurück zu meinem Stamm, irgendwas stimmt hier nicht. Wer hat mich wohl hier hergebracht und wie einen Toten liegen gelassen?";
            case TextItemType.Kultraum:
                return "Was für ein grauenhafter Anblick, was für böse Zauber beschwören die Leute hier?! Ich sollte schleunigst den Schlüssel holen und von hier verschwinden. Ob das hier die Gräber meiner Brüder und Schwestern sind?";
            case TextItemType.Keller:
                return "Oben war kein Schlüssel zum Stall, vielleicht ist er im Keller… Hmm… Das ist ja ein großer Stollen, was geht hier vor sich?";
            case TextItemType.Schalter:
                return "Ob diese Hebel etwas mit dem Torbogen zu tun haben?"; 
            case TextItemType.Pferd:
                return "Windmähne, da bist du ja! Wer hat dich hier eingesperrt in diesem engen Käfig? Warte nur, ich suche den Schlüssel und befreie dich, dann fliehen wir von diesem schaurigen Acker!"; 
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
