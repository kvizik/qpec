using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class ToggleOn : MonoBehaviour
{
    BludoChooser blCh;
    public Toggle tgl;
    public Text bludoName;
    public Image chosenBludo, chosenBludoTwo;
    public Image ingrOne, ingrTwo, ingrThree, ingrFour, ingrFive, ingrSeven, ingrEight, ingrNine, ingrTen;

    
    void Start()
    {
        blCh = GameObject.FindWithTag("Chooser").GetComponent<BludoChooser>();
    }


    void Update()
    {
        if(tgl.isOn == true && gameObject.tag == "Pizza")
        {
            bludoName.text = "Ты выбрал " + blCh.bludos[0];
            chosenBludo.sprite = blCh.bludoSpriteList[0];
            chosenBludo.SetNativeSize();
            chosenBludoTwo.sprite = blCh.bludoSpriteList[0];
            chosenBludoTwo.SetNativeSize();
            blCh.currentBludo = "Пицца";
        }
        else if (tgl.isOn && gameObject.tag == "Borsch")
        {
            bludoName.text = "Ты выбрал " + blCh.bludos[1];
            chosenBludo.sprite = blCh.bludoSpriteList[1];
            chosenBludo.SetNativeSize();
            chosenBludoTwo.sprite = blCh.bludoSpriteList[1];
            chosenBludoTwo.SetNativeSize();
            blCh.currentBludo = "Борщ";
        }
        else if (tgl.isOn && gameObject.tag == "Tort")
        {
            bludoName.text = "Ты выбрал " + blCh.bludos[2];
            chosenBludo.sprite = blCh.bludoSpriteList[2];
            chosenBludo.SetNativeSize();
            chosenBludoTwo.sprite = blCh.bludoSpriteList[2];
            chosenBludoTwo.SetNativeSize();
            blCh.currentBludo = "Торт";
        }
        else if (tgl.isOn && gameObject.tag == "Omelet")
        {
            bludoName.text = "Ты выбрал " + blCh.bludos[3];
            chosenBludo.sprite = blCh.bludoSpriteList[3];
            chosenBludo.SetNativeSize();
            chosenBludoTwo.sprite = blCh.bludoSpriteList[3];
            chosenBludoTwo.SetNativeSize();
            blCh.currentBludo = "Омлет";
        }
        else if (tgl.isOn && gameObject.tag == "Kotlets")
        {
            bludoName.text = "Ты выбрал " + blCh.bludos[4];
            chosenBludo.sprite = blCh.bludoSpriteList[4];
            chosenBludo.SetNativeSize();
            chosenBludoTwo.sprite = blCh.bludoSpriteList[4];
            chosenBludoTwo.SetNativeSize();
            blCh.currentBludo = "Котлеты";
        }
        else if (tgl.isOn && gameObject.tag == "Olivier")
        {
            bludoName.text = "Ты выбрал " + blCh.bludos[5];
            chosenBludo.sprite = blCh.bludoSpriteList[5];
            chosenBludo.SetNativeSize();
            chosenBludoTwo.sprite = blCh.bludoSpriteList[5];
            chosenBludoTwo.SetNativeSize();
            blCh.currentBludo = "Оливье";
        }
        else if (tgl.isOn && gameObject.tag == "Schi")
        {
            bludoName.text = "Ты выбрал " + blCh.bludos[6];
            chosenBludo.sprite = blCh.bludoSpriteList[6];
            chosenBludo.SetNativeSize();
            chosenBludoTwo.sprite = blCh.bludoSpriteList[6];
            chosenBludoTwo.SetNativeSize();
            blCh.currentBludo = "Щи";
        }
        else if (tgl.isOn && gameObject.tag == "Solyanka")
        {
            bludoName.text = "Ты выбрал " + blCh.bludos[7];
            chosenBludo.sprite = blCh.bludoSpriteList[7];
            chosenBludo.SetNativeSize();
            chosenBludoTwo.sprite = blCh.bludoSpriteList[7];
            chosenBludoTwo.SetNativeSize();
            blCh.currentBludo = "Солянка";
        }
        else if (tgl.isOn && gameObject.tag == "Ragu")
        {
            bludoName.text = "Ты выбрал " + blCh.bludos[8];
            chosenBludo.sprite = blCh.bludoSpriteList[8];
            chosenBludo.SetNativeSize();
            chosenBludoTwo.sprite = blCh.bludoSpriteList[8];
            chosenBludoTwo.SetNativeSize();
            blCh.currentBludo = "Рагу";
        }

    }

}
