using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EndingText : MonoBehaviour {

	public Text EndingTextfield;

	public string Texttowrite;

	// Use this for initialization
	void Start () {
		

		Texttowrite = "So viele Jahre ist es bereits her, dass ich an diesen Ort kam. " +
			"Ich weiß noch, es war Liebe auf den ersten Blick, als ich die kleinen, " +
			"grünen Blättchen aus dem Eis ragen sah. Er hat sich so viel Mühe gegeben, " +
			"trotz des Frostes an seinen frisch gekeimten Blättchen die Sonne zu erblicken. " +
			"Sein Mut und seine Tapferkeit ließen die Blüten an meinen Händen erblühen. Ich wusste, " +
			"wir waren füreinander bestimmt! Die Drachen mussten mich hier gewollt haben - hier bei ihm." +
			"\nDamals schaufelte ich den Schnee mit meinen Händen ein wenig bei Seite und wärmte die kleinen Blättchen. " +
			"Ich ahnte damals noch nicht, dass er so groß werden würde, aber wir würden beieinander bleiben, immer für " +
			"einander da sein, bis diese Welt vernichtet [werden] würde.";
		
		StartCoroutine (Spell ());

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	IEnumerator Spell()
	{
		for (int i = 0; i < Texttowrite.Length; i++) {
			EndingTextfield.text = EndingTextfield.text+ Texttowrite [i];
			yield return new WaitForSeconds (0.05f);
		}

	}
}
