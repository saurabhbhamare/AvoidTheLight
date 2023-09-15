using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    private float vertical, horizontal;
    private Rigidbody2D _rigidbody;
    public ScoreController scoreController;
    public GameOverController gameOverController;
    
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        PlayerMovement();
    }
    void PlayerMovement()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        _rigidbody.velocity = new Vector2 (horizontal * moveSpeed,  vertical * moveSpeed);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Light")
        {
            Debug.Log("Game over");
            gameOverController.PlayerDied();
            this.enabled = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Insect")
        {
            scoreController.IncreaseScore(1);
        }
    }
}
