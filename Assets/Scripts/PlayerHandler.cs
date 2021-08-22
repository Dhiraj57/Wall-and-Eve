using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHandler : MonoBehaviour
{
    private Rigidbody2D rigidBody2d;
    private bool isGrounded;

    public GameManager manager;

    private void Awake()
    {
        rigidBody2d = transform.GetComponent<Rigidbody2D>();
        //boxCollider2d = transform.GetComponent<BoxCollider2D>();
        isGrounded = true;
    }

    private void Update()
    {
        if(Input.GetKey(KeyCode.Space) && isGrounded == true)
        {
            SoundManager.Instance.Play(SoundManager.Sounds.Jump);
            rigidBody2d.velocity = new Vector3(0, 20, 0);
            isGrounded = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isGrounded = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Obstacle")
        {
            manager.GameOver();
        }
    }

    /*private bool IsGrounded()
    {
        float extraHeightText = 0.01f;
        RaycastHit2D rayCastHit =  Physics2D.Raycast(boxCollider2d.bounds.center, Vector2.down, boxCollider2d.bounds.extents.y + extraHeightText);
        Color rayColor = Color.green;

        //if(rayCastHit.collider != null)
        {
            Debug.DrawRay(boxCollider2d.bounds.center, Vector2.down * (boxCollider2d.bounds.extents.y + extraHeightText), rayColor);
        }

        return rayCastHit.collider != null;
    }*/
}
