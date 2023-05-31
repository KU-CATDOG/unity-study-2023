using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _inst = null;

    public static GameManager Inst
    {
        get
        {
            return _inst;
        }
    }

    [SerializeField]
    private StarCount sc;
    private int starCount = 0;
    public int StarCount
    {
        get
        {
            return starCount;
        }
        set
        {
            starCount = value;

            sc.UpdateText(starCount);
            if (starCount <= 0)
                StageClear();
        }
    }

    private void Awake()
    {
        if (_inst == null)
        {
            _inst = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    public void StageFail()
    {
        Debug.Log($"Stage Fail..");
    }

    public void StageClear()
    {
        Debug.Log($"Stage Clear!!");
    }
}
