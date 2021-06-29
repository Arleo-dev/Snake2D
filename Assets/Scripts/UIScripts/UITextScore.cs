using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class UITextScore : MonoBehaviour
{
    private Text _text;
    public int Score { get; private set; }
    private void Start()
    {
        _text = GetComponent<Text>();
    }
    private void Update()
    {
        _text.text = "Score: " + Score;
    }
    public void ScoreAdd()
    {
        Score++;
    }
}
