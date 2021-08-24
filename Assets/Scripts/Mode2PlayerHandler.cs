using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mode2PlayerHandler : MonoBehaviour
{
    private Rigidbody2D rigidBody2d;
    public bool isGrounded;

    public GameManager2 manager;

    private void Awake()
    {
        rigidBody2d = transform.GetComponent<Rigidbody2D>();
        isGrounded = true;
    }

    private void Update()
    {
        if ((isGrounded) && Time.timeScale != 0)
        {     
            if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetMouseButtonDown(0))
            {
                SoundManager.Instance.Play(SoundManager.Sounds.Jump);
                rigidBody2d.velocity = new Vector3(0, 20, 0);
                isGrounded = false;
            }
        }

        if ((!isGrounded) && Time.timeScale != 0)
        {         
            if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow) || Input.GetMouseButtonDown(1))
            {
                SoundManager.Instance.Play(SoundManager.Sounds.Jump);
                rigidBody2d.velocity = new Vector3(0, -20, 0);
                isGrounded = false;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isGrounded = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Obstacle")
        {
            SoundManager.Instance.Play(SoundManager.Sounds.Hit);
            manager.GameOver();
        }
    }
}
