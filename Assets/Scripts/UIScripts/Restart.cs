using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restart : MonoBehaviour
{
    public void RestartScene()
    {
        Time.timeScale = 1;
        Application.LoadLevel(1);
    }
}
