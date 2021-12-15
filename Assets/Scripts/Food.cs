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

        if (bChooser.currentBludo == "Пицца")
        {
            foodListOne.text = "Мука";
            foodListTwo.text = "Соль";
            foodListThree.text = "Дрожжи";
            foodListFour.text = "Томатная паста";
            foodListFive.text = "Приправа";
            foodListSix.text = "Оливковое масло";
            foodListSeven.text = "Сыр";
            foodListEight.text = "Колбаса копченая";
            foodListNine.text = "";
            if (Muka >= 1 && Sol >= 1 && Droji >= 1 && TomatPasta >= 1 && Priprava >= 1 && OlivkOil >= 1 && Syr >= 1 && KolbasaTwo >= 1)
            {
                allBought = true;
            }
            else allBought = false;
        }
        else if (bChooser.currentBludo == "Омлет")
        {
            foodListOne.text = "Молоко";
            foodListTwo.text = "Соль";
            foodListThree.text = "Яйца";
            foodListFour.text = "Растительное масло";
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
        else if (bChooser.currentBludo == "Щи")
        {
            {
                foodListOne.text = "Мясо";
                foodListTwo.text = "Лук";
                foodListThree.text = "Капуста";
                foodListFour.text = "Морковь";
                foodListFive.text = "Растительное масло";
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
        else if (bChooser.currentBludo == "Борщ")
        {
            {
                foodListOne.text = "Мясо";
                foodListTwo.text = "Свекла";
                foodListThree.text = "Лук";
                foodListFour.text = "Томатная паста";
                foodListFive.text = "Капуста";
                foodListSix.text = "Морковь";
                foodListSeven.text = "Соль";
                foodListEight.text = "";
                foodListNine.text = "";
                if (Myaso >= 1 && Svekla >= 1 && Luk >= 1 && TomatPasta >= 1 && Kapusta >= 1 && Morkov >= 1 && Sol >= 1)
                {
                    allBought = true;
                }
                else allBought = false;
            }
        }
        else if (bChooser.currentBludo == "Оливье")
        {
            {
                foodListOne.text = "Картошка";
                foodListTwo.text = "Морковь";
                foodListThree.text = "Яйца";
                foodListFour.text = "Колбаса вареная";
                foodListFive.text = "Огурцы";
                foodListSix.text = "Горох";
                foodListSeven.text = "Майонез";
                foodListEight.text = "Соль";
                foodListNine.text = "";

                if (Kartoha >= 1 && Morkov >= 1 && Yaica >= 1 && KolbasaOne >= 1 && Ogurci >= 1 && Goroh >= 1 && Mayonez >= 1 && Sol >= 1)
                {
                    allBought = true;
                }
                else allBought = false;
            }
        }
        else if (bChooser.currentBludo == "Солянка")
        {
            foodListOne.text = "Мясо";
            foodListTwo.text = "Колбаса копченая";
            foodListThree.text = "Чеснок";
            foodListFour.text = "Лук";
            foodListFive.text = "Томатная паста";
            foodListSix.text = "Огурцы";
            foodListSeven.text = "Оливки";
            foodListEight.text = "Соль";
            foodListNine.text = "Лимон";
            if (Myaso >= 1 && KolbasaTwo >= 1 && Chesnok >= 1 && Luk >= 1 && TomatPasta >= 1 && Ogurci >= 1 && Olivki >= 1 && Sol >= 1 && Limon >= 1)
            {
                allBought = true;
            }
            else allBought = false;
        }
        else if (bChooser.currentBludo == "Рагу")
        {
            foodListOne.text = "Кабачки";
            foodListTwo.text = "Лук";
            foodListThree.text = "Помидоры";
            foodListFour.text = "Морковь";
            foodListFive.text = "Перец";
            foodListSix.text = "Картошка";
            foodListSeven.text = "Чеснок";
            foodListEight.text = "Соль";
            foodListNine.text = "Масло растительное";

            if (Kaban >= 1 && Luk >= 1 && Pomidor >= 1 && Morkov >= 1 && PerecTwo >= 1 && Kartoha >= 1 && Chesnok >= 1 && Sol >= 1 && MasloRast >= 1)
            {
                allBought = true;
            }
            else allBought = false;
        }
        else if (bChooser.currentBludo == "Котлеты")
        {
            foodListOne.text = "Мясо";
            foodListTwo.text = "Лук";
            foodListThree.text = "Яйца";
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
        else if (bChooser.currentBludo == "Торт")
        {
            foodListOne.text = "Мука";
            foodListTwo.text = "Сливочное масло";
            foodListThree.text = "Соль";
            foodListFour.text = "Молоко";
            foodListFive.text = "Сахар";
            foodListSix.text = "Яйца";
            foodListSeven.text = "Ванилин";
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
