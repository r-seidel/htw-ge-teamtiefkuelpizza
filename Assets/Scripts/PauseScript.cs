using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour
{
    private bool paused = false;
    private object GameManagment;

    void Update()
    {
        if(Input.GetButtonDown("Pause") && !paused ) pause();
        else if(Input.GetButtonDown("Pause") && paused) resume();
        if(Input.GetButtonDown("Quit")) quit();
    }

    private void quit()
    {
        SceneManager.LoadScene(0);
    }

    private void resume()
    {
        paused = false;
        Time.timeScale = 1f;
        transform.Find("PauseScreen").gameObject.SetActive(false);
    }

    private void pause()
    {
        paused = true;
        Time.timeScale = 0f;
        transform.Find("PauseScreen").gameObject.SetActive(true);
    }


}
