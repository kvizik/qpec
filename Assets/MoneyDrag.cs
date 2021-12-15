using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyDrag : MonoBehaviour
{
    private bool isDragging;


    public void OnMouseDown()
    {
        isDragging = true;
    }

    public void OnMouseUp()
    {
        isDragging = false;
    }

    void Update()
    {
        if (isDragging)
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y));
            gameObject.transform.position = mousePosition;
        }  
    }
}
