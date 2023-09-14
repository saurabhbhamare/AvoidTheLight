using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightsController : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    public float speed = 100.0f;
    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        AddStartingForce();
    }
    private void AddStartingForce()
    {
        float x = Random.Range(-1.0f, 1.0f);
        float y = Random.Range(-1.0f, 1.0f);
        Vector2 direction = new Vector2(x, y);
        _rigidbody.AddForce(direction*this.speed);
    }
}
