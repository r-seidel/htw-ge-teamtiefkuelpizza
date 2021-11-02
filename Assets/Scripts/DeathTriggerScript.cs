using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeathTriggerScript : MonoBehaviour
{
    public GameObject display;
    private int deletedGos = 0;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
        deletedGos++;
        UpdateDisplay();
    }

    void UpdateDisplay()
    {
        display.GetComponent<Text>().text = "Missed Toppings: " + deletedGos;
    }
}
