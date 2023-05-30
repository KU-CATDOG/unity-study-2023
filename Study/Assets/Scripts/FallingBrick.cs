using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingBrick : MonoBehaviour, IStep
{
    public void OnStep(Ball ball)
    {
        var rigid2d = GetComponent<Rigidbody2D>();

        rigid2d.bodyType = RigidbodyType2D.Dynamic;
        rigid2d.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezeRotation;
    }
}
