using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    // Start is called before the first frame update
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void ShowHelp()
    {
        SceneManager.LoadScene(2);
    }

    public void BackToTitle()
    {
        SceneManager.LoadScene(0);
    }


    public void toGoal()
    {
        transform.Find("GOAL").gameObject.SetActive(true);
        transform.Find("CONTROLS").gameObject.SetActive(false);
        transform.Find("TIPS").gameObject.SetActive(false);
    }

    public void toControls()
    {
        transform.Find("CONTROLS").gameObject.SetActive(true);
        transform.Find("GOAL").gameObject.SetActive(false);
        transform.Find("TIPS").gameObject.SetActive(false);
    }

    public void toTips()
    {
        transform.Find("TIPS").gameObject.SetActive(true);
        transform.Find("CONTROLS").gameObject.SetActive(false);
        transform.Find("GOAL").gameObject.SetActive(false);
    }

    public void QuitGame()
    {

        Application.Quit();
    }

}

