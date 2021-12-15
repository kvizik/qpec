using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UstroyDestroy : MonoBehaviour
{
    public GameObject cnvsToOpen;

    public void CanvOpen()
    {
        cnvsToOpen.SetActive(true);
    }
}
