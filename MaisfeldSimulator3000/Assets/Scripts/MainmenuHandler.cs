using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainmenuHandler : MonoBehaviour {

    public Canvas MainCanvas;
    public Canvas CreditCanvas;

    public void ClickStart()
    {
        SceneManager.LoadScene(1);
    }
    public void ClickCredits()
    {
        MainCanvas.gameObject.SetActive(false);
        CreditCanvas.gameObject.SetActive(true);
    }
    public void ClickBackCredits()
    {
        MainCanvas.gameObject.SetActive(true);
        CreditCanvas.gameObject.SetActive(false);
    }
    public void ClickExitGame()
    {
        Application.Quit();
    }
}
