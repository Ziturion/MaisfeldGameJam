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

	public Image Background;

	public Sprite BesteEnde;
	public Sprite BisteAbsolutTod;
	public Sprite BisteAuchTod;
	public Sprite BisteAuchNochTod;
	public Sprite UberlebtAberSchlechtesEnde;

    void Awake()
    {
        textfeld.fontSize = 30;
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    void OnTriggerEnter(Collider other)
    {
        hasHorse = Player.GetComponent<FirstPersonController>().GethasHorse();
        hasKey = Player.GetComponent<FirstPersonController>().GethasKey();
        hasShotgun = Player.GetComponent<FirstPersonController>().GethasShotgun();

        AudioSource[] auditemp = Player.GetComponents<AudioSource>();

        foreach (AudioSource audi in auditemp)
        {
            audi.Stop();
        }
        
        
        Destroy(Player.GetComponent<FirstPersonController>());

		if (hasHorse && hasKey && hasShotgun) {
			Texttowrite = "Ein Schauer läuft mir über den Rücken, als ich in die Freiheit reite. Gerade, als ich durch das Tor galoppiere und den Wind in meinen Haaren spüre, höre ich noch einen wütenden Schrei, doch ich drehe mich nicht mehr um. Dieser Ort ist böse, verflucht. Die Geister der Prärie suchen ihn heim und die Seelen meiner Brüder und Schwestern sind für immer verloren. Ich muss zurück zum Stamm und alle warnen, nie wieder dieses Land zu betreten!";
			Background.sprite = BesteEnde;
			textfeld.color = Color.white;
		}
		else if (!hasHorse && !hasKey && !hasShotgun) {
			Texttowrite = "Ich lasse mein Pferd zurück, ich weiß nicht, ob ich es alleine schaffe, doch ich muss es versuchen! Ich kann nicht zulassen, dass meine Brüder und Schwestern hier gefangen werden und ich wage mich keinen Schritt mehr in dieses verfluchte Feld! Moment, was war das?! Eine Tür? Ich sollte fliehen, so schnell ich kann. Die Geister der Wildnis werden entscheiden!\nIch werde Schwächer…. Seit drei Tagen kein Wasser, kein Essen, kein Lebenszeichen, nur Wüste… Staub und Sonne.. Mir wird schwarz vor Augen, oh große Wildgeist des Pferdes, empfange mich.\n";
			Background.sprite = BisteAbsolutTod;
			textfeld.color = Color.white;
		}
		else if (!hasHorse && hasKey && !hasShotgun) {
			Texttowrite = "Ich muss hier weg, das ist Zauber der bösen Geister! Ich darf hier nicht länger verweilen! Sonst kriegen sie mich! Jetzt oder nie! Fliehen! Beim großen Geisterpferd, ich höre sie, sie kommen, sie wollen mich, mir werden die Füße schwer! Was passiert mit mir, ich werde so schwach?! Großer Bär, es ist vorbei, nimm mich auf! Sie haben mich… Ich werde nun einer von ihnen, eine Vogelscheuche, leer von Geist und Blut, ausgesaugt und benutzt, wie meine Brüder und Schwestern hier...";
			Background.sprite = BisteAuchTod;
		}
		else if (hasHorse && hasKey && !hasShotgun) {
			Texttowrite = "Ich habe es geschafft, ich habe Windmähne befreit, nun müssen wir von hier verschwinden, ehe die Geister wiederkommen! Nur noch ein paar Momente, dann bin ich frei. Moment, was war das?! Das Bleichgesicht, beim großen Bären, er hat ein Schießeisen, lauf Windmähne, lauf!\n*SCHUSSGERÄUSCH.*\nArrrghhhh….. Flieh, Windmähne, erzähle allen was hier geschah, ich bin verloren!";
			Background.sprite = BisteAuchNochTod;
		}
		else if (!hasHorse && !hasKey && hasShotgun) {
			Texttowrite = "Ich muss Windmähne zurücklassen! Ich muss weg, so weit weg ich kann, weg von diesem von den Geistern verlassenen Ort. Etwas böses ist hier! Ich kann nicht zurück zu meinem Volk, nicht ohne mein Pferd. Ich schlage mich durch, bis zum nächsten Ort und versuche bei den Bleichgesichtern aufgenommen zu werden. Nie wieder kehre ich hierhin zurück, nie wieder werde ich eine Heimat haben, oder einen Freund, doch ich lebe.";
			Background.sprite = UberlebtAberSchlechtesEnde;
			textfeld.color = Color.black;
		}
            
        else
        {
			Texttowrite = "Ich muss Windmähne zurücklassen! Ich muss weg, so weit weg ich kann, weg von diesem von den Geistern verlassenen Ort. Etwas böses ist hier! Ich kann nicht zurück zu meinem Volk, nicht ohne mein Pferd. Ich schlage mich durch, bis zum nächsten Ort und versuche bei den Bleichgesichtern aufgenommen zu werden. Nie wieder kehre ich hierhin zurück, nie wieder werde ich eine Heimat haben, oder einen Freund, doch ich lebe.";
			Background.sprite = UberlebtAberSchlechtesEnde;
			textfeld.color = Color.black;
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
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene(0);

        }
}
