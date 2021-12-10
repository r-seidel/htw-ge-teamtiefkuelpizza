using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using jim.Scoreboards;
using UnityEngine.SceneManagement;

public class TextInputScript : MonoBehaviour
{
    public Text gt;
    public GameObject sb;

    void Start()
    {
        gt = GetComponent<Text>();
    }

    void Update()
    {
        foreach (char c in Input.inputString)
        {
            if (c == '\b') // has backspace/delete been pressed?
            {
                if (gt.text.Length != 0)
                {
                    gt.text = gt.text.Substring(0, gt.text.Length - 1);
                }
            }
            else if ((c == '\n') || (c == '\r')) // enter/return
            {
                if(gt.text != "")
                {
                    print("User entered their name: " + gt.text);
                    sb.GetComponent<jim.Scoreboards.Scoreboard>().addEntry(
                        new ScoreboardEntryData()
                        {
                            entryName = gt.text,
                            entryScore = Score.score
                        });
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                }
            }
            else
            {
                gt.text += c;
            }
        }
    }
}