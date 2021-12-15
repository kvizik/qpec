using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBarScript : MonoBehaviour
{


    public Button button;
    public GameObject foodImg, pH;
    private Slider slider;

    public float fillSpeed = 0.2f;
    private float targetProgress = 0;


    private void Awake()
    {
        slider = gameObject.GetComponent<Slider>();
    }

    void Start()
    {
        incrementProgress(1);
    }

    // Update is called once per frame
    void Update()
    {
        if (slider.value < targetProgress)
        { slider.value += fillSpeed * Time.deltaTime; }
        else if (slider.value >= targetProgress)
        {
            button.interactable = true;
            foodImg.SetActive(true);
            pH.SetActive(false);
        }

    }

    public void AppQt()
    {
        Application.Quit();
        Debug.Log("Bye!");
    }

    public void incrementProgress(float newProgress)
    {
        targetProgress = slider.value + newProgress;
    }
}
