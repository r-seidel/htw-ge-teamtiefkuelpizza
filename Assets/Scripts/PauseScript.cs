using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour
{
    private bool paused = false;

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
        transform.Find("PauseScreen").gameObject.SetActive(false);
        Time.timeScale = 1.0f;
    }

    private void pause()
    {
        paused = true;
        Time.timeScale = 0;
        transform.Find("PauseScreen").gameObject.SetActive(true);
    }


}
