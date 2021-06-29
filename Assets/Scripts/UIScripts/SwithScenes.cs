using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwithScenes : MonoBehaviour
{
    [SerializeField] private int _levelIndex;
    public void Switch(bool enable)
    {
        if (enable)
        {
            Application.LoadLevel(_levelIndex);
        }
    }
}
