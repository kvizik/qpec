using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chooser : MonoBehaviour
{
    public GameObject chooserCanvas;
    public GameObject mainGameCanvas;

    public void GoGoGo()
    {
        chooserCanvas.SetActive(false);
        mainGameCanvas.SetActive(true);
    }
}
