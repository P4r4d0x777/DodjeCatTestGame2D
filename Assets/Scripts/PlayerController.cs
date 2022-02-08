using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D _rigidBody;

    public float _speed;

    public SpriteRenderer _spriteRenderer;

    public float _xLimit;

    private void Awake()
    {
        _rigidBody = GetComponent<Rigidbody2D>();

        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        FlipPlayer();

        float xInput = 0;

        if (Input.GetMouseButton(0))
        {
            if (Input.mousePosition.x < Screen.width / 2)
            {
                GameObject.FindObjectOfType<Animator>().SetBool("isMoving", true);
                xInput = -1f;
            }
            else
            {
                GameObject.FindObjectOfType<Animator>().SetBool("isMoving", true);
                xInput = 1f;
            }
        }
        else
        {
            xInput = 0f;
        }

        //_rigidBody.AddForce(new Vector2(1,0) * _speed * xInput * Time.fixedDeltaTime);
        _rigidBody.velocity = new Vector2(_speed * xInput, transform.position.y);
    }

    private void FixedUpdate()
    {
    }

    private void FlipPlayer()
    {
        if(_rigidBody.velocity.x < 0)
        {
            _spriteRenderer.flipX = true;
        }
        else if(_rigidBody.velocity.x > 0)
        {
            _spriteRenderer.flipX = false;
        }
        else if(_rigidBody.velocity.x == 0)
        {
            GameObject.FindObjectOfType<Animator>().SetBool("isMoving", false);
        }
    }

}
