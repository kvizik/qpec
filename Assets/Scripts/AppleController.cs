using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AppleController : MonoBehaviour
{

    public Rigidbody2D rb;
    public GameController gm;
    public Transform yabloko;
    
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnMouseDown()
    {
        if (gm.timeStp != 0)
        {
            yabloko.position = new Vector3(Random.Range(-4.33f, 8.2f), 3.09f, yabloko.position.z);
            Debug.Log("чпоньк");
            
            gm.appleCount += 10;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (gm.timeStp != 0)
        {
            if (collision.gameObject.tag == "DropZone")
            {
                //gameObject.SetActive(false);
                Debug.Log("DropZone passed");
                gm.appleCount -= 10;
                yabloko.position = new Vector3(Random.Range(-4.33f, 8.2f), 3.09f, yabloko.position.z);
            }
            else
                Debug.Log("OtherZone passed");
        }
    }

    void Update()
    {

    }






}
