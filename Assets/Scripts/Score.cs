using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {
    
    public GameObject scoreDisplay;
    public GameObject lifesDisplay;
    public static int score = 0;
    public static int lifes = 5;

    public void Update()
    {
        scoreDisplay.GetComponent<Text>().text = "Score: " + score;
    }

}