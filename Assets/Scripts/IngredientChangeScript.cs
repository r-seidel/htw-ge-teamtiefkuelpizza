using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngredientChangeScript : MonoBehaviour
{
    public string password;
    public GameObject[] newIngredients;
    public GameObject spawner;

    private char[] pswrd;
    private int progression = 0;
    private readonly Dictionary<char, KeyCode> _keycodeCache = new Dictionary<char, KeyCode>();

    void Start()
    {
        pswrd = password.ToCharArray();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            if (Input.GetKeyDown(GetKeyCode(pswrd[progression])))
            {
                progression++;

                if(progression == pswrd.Length)
                {
                    PasswordEntered();
                    progression = 0;
                }
            }
            else
            {
                progression = 0;
            }
        } 
    }

    private KeyCode GetKeyCode(char character)
    {
        // Get from cache if it was taken before to prevent unnecessary enum parse
        KeyCode code;
        if (_keycodeCache.TryGetValue(character, out code)) return code;
        // Cast to it's integer value
        int alphaValue = character;
        code = (KeyCode)System.Enum.Parse(typeof(KeyCode), alphaValue.ToString());
        _keycodeCache.Add(character, code);
        return code;
    }

    private void PasswordEntered()
    {
        spawner.GetComponent<SpawnerScript>().drops = newIngredients;
        spawner.GetComponent<SpawnerScript>().ResetBundle();
    }
}
