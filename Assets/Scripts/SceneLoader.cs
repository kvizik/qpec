using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    SceneManager SceneManager;

    public void LoadNextScene(int index)
    {
        SceneManager.LoadScene(index);
    }

}
