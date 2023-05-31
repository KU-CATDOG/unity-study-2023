using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Player")) return;

        GameManager.Inst.StarCount -= 1;
        Destroy(gameObject);
    }

    private void Start()
    {
        GameManager.Inst.StarCount += 1;
    }
}
