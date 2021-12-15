using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class MoneySlot : MonoBehaviour
{
    public int currCashMon = 0;
    public int currZMon = 6;
    public float[] moneyCashPosition = { -0.7538095f, 0.8119078f, 2.322365f, 3.897292f, 5.481429f, 6.973465f };
    public float[] moneyZonePosition = { -6.633567f, -5.15492f, -3.658456f, -2.161993f, -0.6655297f, 0.8487492f };
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if()
    }
}
