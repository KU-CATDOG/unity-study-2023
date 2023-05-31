using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StarCount : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI star;

    public void UpdateText(int count)
    {
        star.text = count.ToString();
    }
}
