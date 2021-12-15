using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CartScript : MonoBehaviour
{
    public Text payMoney, neededMoney, checkoutText;
    public int payedMoney;
    public int playerMoney = 1000;
    public int price;
    Food foodC;
    public Button goBackButton, goPayButton, payButton;
    public Text pMoney, priceText, squares, circles, textusFinalus;
    
    void Start()
    {
        foodC = GameObject.FindWithTag("Food").GetComponent<Food>(); // Скрипт не находит тэг "Food", тк элемент выключен в иерархии. Переместить скрипт во внешние элементы
        price = foodC.FoodCounter* 10;

        pMoney.text = playerMoney.ToString();

        
    }

    void Update()
    {
        if (price <= playerMoney && foodC.allBought == true)
        {
            /*    goPayButton.SetActive(true);
                goBackButton.SetActive(false); */
            goPayButton.interactable = true;
            goBackButton.interactable = false;
            textusFinalus.text = "Тебе хватает денег, можешь оплачивать покупки!";
        }
        else if (price > playerMoney)
        {
            /*         goPayButton.SetActive(false);
                     goBackButton.SetActive(true); */
            goPayButton.interactable = false;
            goBackButton.interactable = true;
            textusFinalus.text = "Тебе не хватает денег, собери продукты заново или выложи лишнее из корзины!";
        }
        else if (price == 0)
        {
            goPayButton.interactable = false;
            goBackButton.interactable = true;
            textusFinalus.text = "Ты ничего не купил, попробуй заново!";
        }
        else if (foodC.allBought == false)
        {
            goPayButton.interactable = false;
            goBackButton.interactable = true;
            textusFinalus.text = "Ты купил не все продукты, попробуй заново!";
        }

        if (payedMoney == price)
        {
            payButton.interactable = true;
            checkoutText.text = "Ты положил нужную сумму!";
        }
        else if (payedMoney > price)
        {
            payButton.interactable = false;
            checkoutText.text = "Ты положил больше, чем нужно!";
        }
        else if (payedMoney < price)
        {
            payButton.interactable = false;
            checkoutText.text = "Ты положил меньше, чем нужно!";
        }
        neededMoney.text = "Сумма к оплате: "+price.ToString();
        priceText.text = price.ToString();
    }
}
