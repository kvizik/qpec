using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "PlayerMoney")
        {
            Debug.Log("Enter");
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "PlayerMoney")
        {
            Debug.Log("Exit");
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "PlayerMoney")
        {
            Debug.Log("stays");
        }
    }
}
