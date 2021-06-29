using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratarCoin : MonoBehaviour
{
    [SerializeField] private GameObject _coinPref;
    private GameObject _coin;
    private Vector2 _curPos;
    private void AddNewFood()
    {
        RandPos();
        _coin = GameObject.Instantiate(_coinPref, _curPos, Quaternion.identity, transform) as GameObject;
    }
    private void RandPos()
    {
        _curPos = new Vector2(Random.Range(-9f, 9f), Random.Range(-4.5f, 4.5f));
    }

    private void Update()
    {
        if (!_coin)
        {
            AddNewFood();
        }
    }
}
