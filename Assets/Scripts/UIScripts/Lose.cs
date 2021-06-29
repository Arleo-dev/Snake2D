using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lose : MonoBehaviour
{
    public void LoseInGame()
    {
        Time.timeScale = 0;
        gameObject.SetActive(true);
    }
}
