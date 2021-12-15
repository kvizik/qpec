using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameRestartScript : MonoBehaviour
{
    public void InitiateRestart()
    {
        SceneManager.LoadScene("MainPart");
    }
}
