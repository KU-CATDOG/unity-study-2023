using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField]
    private float acceleration;
    [SerializeField]
    private float maxSpeed;

    private Rigidbody2D rigid2d;

    private void Awake()
    {
        rigid2d = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        var direction = Input.GetAxisRaw("Horizontal");

        rigid2d.velocity = new Vector2(Mathf.Clamp(rigid2d.velocity.x + direction * acceleration, -maxSpeed, maxSpeed), rigid2d.velocity.y);
    }
}
