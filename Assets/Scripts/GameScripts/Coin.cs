using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public static Coin singleton;
    public int Score { get; private set; } = 10;

    private void Awake()
    {
        singleton = this;
    }
    private void OnTriggerEnter2D(Collider2D snakeCheck)
    {
        if (snakeCheck.GetComponent<SnakeController>())
        {
            snakeCheck.GetComponent<Tail>().AddBody();
            Score++;
            Destroy(gameObject);
        }
    }
}
