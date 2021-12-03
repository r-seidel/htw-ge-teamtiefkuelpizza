using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeScript : MonoBehaviour
{
    public GameObject[] lifes;
    private int lifeAmount;

    private void Start()
    {
        lifeAmount = lifes.Length;
    }

    public void RemoveLife(int amount = 1)
    {
        lifeAmount -= amount;
        lifes[lifeAmount].SetActive(false);

        if(lifeAmount == 0)
        {
            Lose();
        }
    }

    public void Lose()
    {
        //TODO: Integrate Lose
        lifeAmount = 3;
    }
}
