using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField]
    private float acceleration;
    [SerializeField]
    private float maxSpeed;
    [SerializeField]
    private float jumpForce;

    private Rigidbody2D rigid2d;

    private void Awake()
    {
        rigid2d = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        Move();
        Jump();
    }

    private void Move()
    {
        var direction = Input.GetAxisRaw("Horizontal");

        rigid2d.velocity = new Vector2(Mathf.Clamp(rigid2d.velocity.x + direction * acceleration, -maxSpeed, maxSpeed), rigid2d.velocity.y);
    }

    private void Jump()
    {
        var ray = Physics2D.Raycast(transform.position, Vector2.down, 0.37f, LayerMask.GetMask("Ground"));

        if (ray.collider == null) return;

        rigid2d.velocity = new Vector2(rigid2d.velocity.x, 0);
        rigid2d.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }

    // private void OnDrawGizmos()
    // {
    //     Debug.DrawRay(transform.position, Vector2.down * 0.36f);
    // }
}
