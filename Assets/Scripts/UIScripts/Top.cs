using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Top : MonoBehaviour
{
    [SerializeField] private UITextScore _score;
    [SerializeField]private static int[] _record = new int[5];

    private Text _text;

    private void Record()
    {
        if(_score.Score >= _record[_record.Length -1])
        {
            _record[_record.Length -1] = _score.Score;
            Array.Sort(_record);
            Array.Reverse(_record);
        }
    }
    public void GetArrayScore()
    {
        _text = GetComponent<Text>();
        _text.text = "Top 5 for your race:\nScore: " +_record[0]+ "\nScore: " +  _record[1] + "\nScore: " +  _record[2] + "\nScore: " +  _record[3] + "\nScore: " + _record[4] + "\n";
        
    }
}
