using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FragileBrick : MonoBehaviour, IStep
{
    public void OnStep(Ball ball)
    {
        Destroy(this.gameObject);
    }
}
