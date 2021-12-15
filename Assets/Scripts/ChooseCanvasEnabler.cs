using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChooseCanvasEnabler : MonoBehaviour
{
    public GameObject canvas;
    public GameObject ingredientsCanvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void CanvasIngredientsEnable()
    {
        ingredientsCanvas.SetActive(true);
    }
    public void CanvasIngredientsDisable()
    {
        ingredientsCanvas.SetActive(false);
    }
    public void CanvasEnable()
    {
        canvas.SetActive(true);
    }
    public void CanvasDisable()
    {
        canvas.SetActive(false);
    }
   
}
