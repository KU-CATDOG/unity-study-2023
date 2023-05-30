using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FragileJump : MonoBehaviour, IStep
{
    [SerializeField]
    private float jumpForce;

    public void OnStep(Ball ball)
    {
        var rigid2d = ball.GetComponent<Rigidbody2D>();

        rigid2d.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);

        Destroy(gameObject);
    }
}
