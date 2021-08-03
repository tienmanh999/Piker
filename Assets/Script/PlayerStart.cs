using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStart : MonoBehaviour
{
    public static int Money;
    public int startMoney = 200;

    public static int Pick;
    public int startpick = 2;

    private void Start()
    {
        Money = startMoney;
        Pick = startpick;
    }
}
