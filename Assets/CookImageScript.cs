using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CookImageScript : MonoBehaviour
{
    BludoChooser bChooser;
    void Start()
    {
        bChooser = GameObject.FindWithTag("Chooser").GetComponent<BludoChooser>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
