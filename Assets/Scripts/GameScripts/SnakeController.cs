using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class SnakeController : MonoBehaviour
{
    [SerializeField] private UnityEvent OnEat;
    [SerializeField] private UnityEvent OnDead;
    [SerializeField] private GameObject _lose;

    private float speed = 2;

    private Rigidbody2D _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        Time.timeScale = 1;
    }

   
    public void UpMove()
    {
        GetDirection(Vector2.up);
        GetRotation(90);
    }
    public void DownMove()
    {
        GetDirection(Vector2.down);
        GetRotation(270);
    }
    public void LeftMove()
    {
        GetDirection(Vector2.left);
        GetRotation(180);
    }
    public void RightMove()
    {
        GetDirection(Vector2.right);
        GetRotation(0);
    }
    private Vector3 GetRotation(int angel)
    {
        transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, angel);
        return transform.eulerAngles;
    }
    private Vector2 GetDirection(Vector2 vector)
    {
        _rigidbody.velocity = vector * speed;
        return _rigidbody.velocity;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Coin>())
        {
            OnEat.Invoke();
        }
        else
        {
            OnDead.Invoke();
            Debug.Log(collision.gameObject.name);
        }
    }


}