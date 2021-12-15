using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Food : MonoBehaviour
{
    BludoChooser bChooser;
    GameController gc;
    public int FoodCounter = 0;
    public Text foodCount;
    public Text circlesClicked, squaresClicked;
    public int circles = 0;
    public int squares = 0;
    public int Svekla, Suhari, Vanilin, KolbasaOne, Goroh, Droji, Kaban, Kapusta, Kartoha, KolbasaTwo, Limon, Chesnok, Luk, Maslo, MasloRast, Mayonez, Moloko, Morkov, Muka, Myaso, Ogurci, Olivki, OlivkOil, PerecOne, PerecTwo, Petrushka, Pomidor, Priprava, Sahar, Soda, Sol, Syr, TomatPasta, Yaica = 0;
    public Text foodListOne, foodListTwo, foodListThree, foodListFour, foodListFive, foodListSix, foodListSeven, foodListEight, foodListNine;

    public string[] capturedFood = new string[9];
    public int[] capturedFoodNums = new int[9];

    public bool allBought = false;
    void Start()
    {
        bChooser = GameObject.FindWithTag("Chooser").GetComponent<BludoChooser>();
        gc = GameObject.FindWithTag("GameController").GetComponent<GameController>();
    }


    void Update()
    {
        foodCount.text = (FoodCounter * 10).ToString();
        circlesClicked.text = circles.ToString();
        squaresClicked.text = squares.ToString();

        if (bChooser.currentBludo == "�����")
        {
            foodListOne.text = "����";
            foodListTwo.text = "����";
            foodListThree.text = "������";
            foodListFour.text = "�������� �����";
            foodListFive.text = "��������";
            foodListSix.text = "��������� �����";
            foodListSeven.text = "���";
            foodListEight.text = "������� ��������";
            foodListNine.text = "";
            if (Muka >= 1 && Sol >= 1 && Droji >= 1 && TomatPasta >= 1 && Priprava >= 1 && OlivkOil >= 1 && Syr >= 1 && KolbasaTwo >= 1)
            {
                allBought = true;
            }
            else allBought = false;
        }
        else if (bChooser.currentBludo == "�����")
        {
            foodListOne.text = "������";
            foodListTwo.text = "����";
            foodListThree.text = "����";
            foodListFour.text = "������������ �����";
            foodListFive.text = "";
            foodListSix.text = "";
            foodListSeven.text = "";
            foodListEight.text = "";
            foodListNine.text = "";
            if (Moloko >= 1 && Sol >= 1 && Yaica >= 1 && MasloRast >= 1)
            {
                allBought = true;
            }
            else allBought = false;
        }
        else if (bChooser.currentBludo == "��")
        {
            {
                foodListOne.text = "����";
                foodListTwo.text = "���";
                foodListThree.text = "�������";
                foodListFour.text = "�������";
                foodListFive.text = "������������ �����";
                foodListSix.text = "";
                foodListSeven.text = "";
                foodListEight.text = "";
                foodListNine.text = "";
                if (Myaso >= 1 && Luk >= 1 && Kapusta >= 1 && Morkov >= 1 && MasloRast >= 1)
                {
                    allBought = true;
                }
                else allBought = false;
            }
        }
        else if (bChooser.currentBludo == "����")
        {
            {
                foodListOne.text = "����";
                foodListTwo.text = "������";
                foodListThree.text = "���";
                foodListFour.text = "�������� �����";
                foodListFive.text = "�������";
                foodListSix.text = "�������";
                foodListSeven.text = "����";
                foodListEight.text = "";
                foodListNine.text = "";
                if (Myaso >= 1 && Svekla >= 1 && Luk >= 1 && TomatPasta >= 1 && Kapusta >= 1 && Morkov >= 1 && Sol >= 1)
                {
                    allBought = true;
                }
                else allBought = false;
            }
        }
        else if (bChooser.currentBludo == "������")
        {
            {
                foodListOne.text = "��������";
                foodListTwo.text = "�������";
                foodListThree.text = "����";
                foodListFour.text = "������� �������";
                foodListFive.text = "������";
                foodListSix.text = "�����";
                foodListSeven.text = "�������";
                foodListEight.text = "����";
                foodListNine.text = "";

                if (Kartoha >= 1 && Morkov >= 1 && Yaica >= 1 && KolbasaOne >= 1 && Ogurci >= 1 && Goroh >= 1 && Mayonez >= 1 && Sol >= 1)
                {
                    allBought = true;
                }
                else allBought = false;
            }
        }
        else if (bChooser.currentBludo == "�������")
        {
            foodListOne.text = "����";
            foodListTwo.text = "������� ��������";
            foodListThree.text = "������";
            foodListFour.text = "���";
            foodListFive.text = "�������� �����";
            foodListSix.text = "������";
            foodListSeven.text = "������";
            foodListEight.text = "����";
            foodListNine.text = "�����";
            if (Myaso >= 1 && KolbasaTwo >= 1 && Chesnok >= 1 && Luk >= 1 && TomatPasta >= 1 && Ogurci >= 1 && Olivki >= 1 && Sol >= 1 && Limon >= 1)
            {
                allBought = true;
            }
            else allBought = false;
        }
        else if (bChooser.currentBludo == "����")
        {
            foodListOne.text = "�������";
            foodListTwo.text = "���";
            foodListThree.text = "��������";
            foodListFour.text = "�������";
            foodListFive.text = "�����";
            foodListSix.text = "��������";
            foodListSeven.text = "������";
            foodListEight.text = "����";
            foodListNine.text = "����� ������������";

            if (Kaban >= 1 && Luk >= 1 && Pomidor >= 1 && Morkov >= 1 && PerecTwo >= 1 && Kartoha >= 1 && Chesnok >= 1 && Sol >= 1 && MasloRast >= 1)
            {
                allBought = true;
            }
            else allBought = false;
        }
        else if (bChooser.currentBludo == "�������")
        {
            foodListOne.text = "����";
            foodListTwo.text = "���";
            foodListThree.text = "����";
            foodListFour.text = "";
            foodListFive.text = "";
            foodListSix.text = "";
            foodListSeven.text = "";
            foodListEight.text = "";
            foodListNine.text = "";

            if (Myaso >= 1 && Luk >= 1 && Yaica >= 1)
            {
                allBought = true;
            }
            else allBought = false;
        }
        else if (bChooser.currentBludo == "����")
        {
            foodListOne.text = "����";
            foodListTwo.text = "��������� �����";
            foodListThree.text = "����";
            foodListFour.text = "������";
            foodListFive.text = "�����";
            foodListSix.text = "����";
            foodListSeven.text = "�������";
            foodListEight.text = "";
            foodListNine.text = "";

            if (Muka >= 1 && Maslo >= 0 && Sol >= 1 && Moloko >= 1 && Sahar >= 1 && Yaica >= 1 && Vanilin >= 1)
            {
                allBought = true;
            }
            else allBought = false;
        }
    }
}
