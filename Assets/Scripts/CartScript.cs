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
        foodC = GameObject.FindWithTag("Food").GetComponent<Food>(); // ������ �� ������� ��� "Food", �� ������� �������� � ��������. ����������� ������ �� ������� ��������
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
            textusFinalus.text = "���� ������� �����, ������ ���������� �������!";
        }
        else if (price > playerMoney)
        {
            /*         goPayButton.SetActive(false);
                     goBackButton.SetActive(true); */
            goPayButton.interactable = false;
            goBackButton.interactable = true;
            textusFinalus.text = "���� �� ������� �����, ������ �������� ������ ��� ������ ������ �� �������!";
        }
        else if (price == 0)
        {
            goPayButton.interactable = false;
            goBackButton.interactable = true;
            textusFinalus.text = "�� ������ �� �����, �������� ������!";
        }
        else if (foodC.allBought == false)
        {
            goPayButton.interactable = false;
            goBackButton.interactable = true;
            textusFinalus.text = "�� ����� �� ��� ��������, �������� ������!";
        }

        if (payedMoney == price)
        {
            payButton.interactable = true;
            checkoutText.text = "�� ������� ������ �����!";
        }
        else if (payedMoney > price)
        {
            payButton.interactable = false;
            checkoutText.text = "�� ������� ������, ��� �����!";
        }
        else if (payedMoney < price)
        {
            payButton.interactable = false;
            checkoutText.text = "�� ������� ������, ��� �����!";
        }
        neededMoney.text = "����� � ������: "+price.ToString();
        priceText.text = price.ToString();
    }
}
