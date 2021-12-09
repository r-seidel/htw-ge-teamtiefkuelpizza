using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextUnderscoreBlink : MonoBehaviour
{
    public float interval;

    private Text text;
    private bool written = false;
    private float timer = 0f;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= interval)
        {
            timer = 0f;
            if (written)
            {
                text.text = text.text.Remove(text.text.Length - 1);
            }
            else
            {
                text.text = text.text + "_";
            }
            written = !written;
        }

        if(Input.anyKey && written)
        {
            text.text = text.text.Remove(text.text.Length - 1);
            written = false;
        }
    }
}
