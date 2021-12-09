using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InputMessageScript : MonoBehaviour
{
    void Start()
    {
        GetComponent<Text>().text = " Your Score: " + Score.score + "\n Enter your name:";
        GameObject.Find("SecretManager").GetComponent<PauseScript>().enabled = false;
    }
}
