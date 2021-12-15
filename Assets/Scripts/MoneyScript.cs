using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyScript : MonoBehaviour
{
    Rigidbody2D rb;
    Camera cam;
    bool isInCash = false;
    CartScript cartS;
    MoneySlot mSlot;
    public int nominalKupura;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    
      private void OnMouseDown()
      {
          Debug.Log("Clack-clakc");

          if (isInCash == false)
          {
              cartS.payedMoney += nominalKupura;
              cartS.playerMoney -= nominalKupura;
              cartS.payMoney.text = "—ÛÏÏ‡: " + cartS.payedMoney.ToString();
            isInCash = true;
            transform.position = new Vector2(mSlot.moneyCashPosition[mSlot.currCashMon], 3.859252f);
            transform.rotation = Quaternion.Euler(43.5f, 8f, -1.1f);

            mSlot.currCashMon++;
            mSlot.currZMon--;
        }
          else if (isInCash ==true)
          {
            isInCash = false;
              cartS.payedMoney -= nominalKupura;
              cartS.playerMoney += nominalKupura;
              cartS.payMoney.text = "—ÛÏÏ‡: " + cartS.payedMoney.ToString();
            transform.position = new Vector2(mSlot.moneyZonePosition[mSlot.currZMon], -1.943412f);
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);
            mSlot.currCashMon--;
            mSlot.currZMon++;
        }
      } 
    
    void Update()
    {
        cartS = GameObject.FindWithTag("Cart").GetComponent<CartScript>(); 
        mSlot = GameObject.Find("MoneySlotScript").GetComponent<MoneySlot>();
    }





    
}
