using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenClose : MonoBehaviour
{

    public GameObject toClose, toOpen;

    public void ToClOp()
    {
        toClose.SetActive(false);
        toOpen.SetActive(true);
    }
}
