using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuGameStart : MonoBehaviour
{
    public GameObject mainMenuCanv;
    public GameObject nextCanvas;

    public void MMGameStart()
    {
        mainMenuCanv.SetActive(false);
        nextCanvas.SetActive(true);
    }
}
