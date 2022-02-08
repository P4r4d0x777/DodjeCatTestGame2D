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
    }

    private void FixedUpdate()
    {
        float xInput = 0;

        if(Input.GetMouseButton(0))
        {
            if(Input.mousePosition.x < Screen.width / 2)
            {
                xInput = -1f;
            }
            else
            {
                xInput = 1f;
            }
        }
        else
        {
            xInput = 0f;
        }

        _rigidBody.AddForce(transform.right * _speed * xInput);
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
    }
}
