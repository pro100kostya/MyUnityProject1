using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _jumpSpeed;
    [SerializeField] private LayerCheck _groundCheck;

    private Vector2 _direction;
    private Rigidbody2D _rigidbidy;


    private void Awake()
    {
        _rigidbidy = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        _rigidbidy.velocity = new Vector2(_direction.x * _speed, _rigidbidy.velocity.y);

        var isJumping = _direction.y > 0;
        if (isJumping)
        {
            if (IsGrounded())
            {
                _rigidbidy.AddForce(Vector2.up * _jumpSpeed, ForceMode2D.Impulse);
            }
        } else if (_rigidbidy.velocity.y > 0)
        {
            _rigidbidy.velocity = new Vector2(_rigidbidy.velocity.x, _rigidbidy.velocity.y * 0.5f);
        }
    }

    public void SetDirection(Vector2 direction)
    {
        _direction = direction;
    }

    public void SaySomething()
    {
        Debug.Log("Something");
    }

    private bool IsGrounded()
    {
        return _groundCheck.IsTouchingLayer;
    }
}
