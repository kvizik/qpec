using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    public AppleController ac;

    public float timerStart = 30;
    public Text timerText;
    bool enableTimer = false;
    public int appleCount = 0;
    public Text appleCountText;
    public float timeStp;
    SceneManager SceneManager;
    public GameObject endPanel;
    public Text endText;
    public GameObject chooserCanvas;
    public GameObject mainGameCanvas;



    public void StartMainGame()
    {
        chooserCanvas.SetActive(false);
        mainGameCanvas.SetActive(true);
        enableTimer = true;

    }


    void Start()
    {

        timerText.text = timerStart.ToString();
        
    }


    public void LoadNextScene(int index)
    {
        SceneManager.LoadScene(index);
    }


    public void GamePause()
    {
        timeStp = 0;
    }
    public void GameUnpause()
    {
        timeStp = 1;

    }

    void Update()
    {
        Time.timeScale = timeStp;


        if (enableTimer)
        {
            timerStart -= Time.deltaTime;
            timerText.text = Mathf.Round(timerStart).ToString();
            if (timerStart <= 0)
            {
                timerStart = 30;
                enableTimer = false;
                timerText.text = "Время вышло!";
                endPanel.SetActive(true);
                endText.text = "Молодец! Проверь покупки!";
                GamePause();
            }
        }
    }
}
