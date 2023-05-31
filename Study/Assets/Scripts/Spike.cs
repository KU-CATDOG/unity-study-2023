using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour, IStep
{
    public void OnStep(Ball ball)
    {
        ball.Die();
    }
}
