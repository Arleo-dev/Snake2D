using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGame : MonoBehaviour
{
    public void Quit(bool enable)
    {
        if (enable)
        {
            Application.Quit();
        }
    }
}
