using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BludoChooser : MonoBehaviour
{
    public string[] bludos = { "пиццу", "борщ", "торт", "омлет", "котлеты", "оливье", "щи", "солянку", "рагу" };
    public Sprite[] bludoSpriteList;
    public Sprite[] ingrSpriteList;
    public GameObject[] ingrPrefabs;
    string[] ingrs = {"Чеснок", "Дрожжи", "Горох", "Кабачок", "Капуста", "Картофель", "Вареная колбаса", "Копченая колбаса", "Лимон", "Лук",
        "Масло", "Масло растительное", "Майонез", "Молоко", "Морковь", "Мука", "Мясо", "Огурцы", "Оливки", "Масло оливковое",
        "Перец черный", "Перец болгарский","Петрушка", "Помидор", "Приправа", "Сахар", "Сода", "Соль", "Сухари", "Свекла",
        "Сыр", "Томатная паста", "Ванилин", "Яйца"};
    public List<string> neededIngr = new List<string>();
    public string currentBludo;
    public GameObject ingrsPanel;
    public GameObject pizzaPanel, omeletPanel, schiPanel, borschPanel, olivierPanel, solyankaPanel, raguPanel, cotletsPanel, tortPanel;

    
    void Update()
    {
        if (currentBludo == "Пицца")
        {
            pizzaPanel.SetActive(true);
            omeletPanel.SetActive(false);
            schiPanel.SetActive(false);
            borschPanel.SetActive(false);
            olivierPanel.SetActive(false);
            solyankaPanel.SetActive(false);
            raguPanel.SetActive(false);
            cotletsPanel.SetActive(false);
            tortPanel.SetActive(false);
        }

        else if (currentBludo == "Омлет")
        {
            pizzaPanel.SetActive(false);
            omeletPanel.SetActive(true);
            schiPanel.SetActive(false);
            borschPanel.SetActive(false);
            olivierPanel.SetActive(false);
            solyankaPanel.SetActive(false);
            raguPanel.SetActive(false);
            cotletsPanel.SetActive(false);
            tortPanel.SetActive(false);
        }
        else if (currentBludo == "Щи")
        {
            pizzaPanel.SetActive(false);
            omeletPanel.SetActive(false);
            schiPanel.SetActive(true);
            borschPanel.SetActive(false);
            olivierPanel.SetActive(false);
            solyankaPanel.SetActive(false);
            raguPanel.SetActive(false);
            cotletsPanel.SetActive(false);
            tortPanel.SetActive(false);
        }
        else if (currentBludo == "Борщ")
        {
            pizzaPanel.SetActive(false);
            omeletPanel.SetActive(false);
            schiPanel.SetActive(false);
            borschPanel.SetActive(true);
            olivierPanel.SetActive(false);
            solyankaPanel.SetActive(false);
            raguPanel.SetActive(false);
            cotletsPanel.SetActive(false);
            tortPanel.SetActive(false);
        }
        else if (currentBludo == "Оливье")
        {
            pizzaPanel.SetActive(false);
            omeletPanel.SetActive(false);
            schiPanel.SetActive(false);
            borschPanel.SetActive(false);
            olivierPanel.SetActive(true);
            solyankaPanel.SetActive(false);
            raguPanel.SetActive(false);
            cotletsPanel.SetActive(false);
            tortPanel.SetActive(false);
        }
        else if (currentBludo == "Солянка")
        {
            pizzaPanel.SetActive(false);
            omeletPanel.SetActive(false);
            schiPanel.SetActive(false);
            borschPanel.SetActive(false);
            olivierPanel.SetActive(false);
            solyankaPanel.SetActive(true);
            raguPanel.SetActive(false);
            cotletsPanel.SetActive(false);
            tortPanel.SetActive(false);
        }
        else if (currentBludo == "Рагу")
        {
            pizzaPanel.SetActive(false);
            omeletPanel.SetActive(false);
            schiPanel.SetActive(false);
            borschPanel.SetActive(false);
            olivierPanel.SetActive(false);
            solyankaPanel.SetActive(false);
            raguPanel.SetActive(true);
            cotletsPanel.SetActive(false);
            tortPanel.SetActive(false);
        }
        else if (currentBludo == "Котлеты")
        {
            pizzaPanel.SetActive(false);
            omeletPanel.SetActive(false);
            schiPanel.SetActive(false);
            borschPanel.SetActive(false);
            olivierPanel.SetActive(false);
            solyankaPanel.SetActive(false);
            raguPanel.SetActive(false);
            cotletsPanel.SetActive(true);
            tortPanel.SetActive(false);
        }
        else if (currentBludo == "Торт")
        {
            pizzaPanel.SetActive(false);
            omeletPanel.SetActive(false);
            schiPanel.SetActive(false);
            borschPanel.SetActive(false);
            olivierPanel.SetActive(false);
            solyankaPanel.SetActive(false);
            raguPanel.SetActive(false);
            cotletsPanel.SetActive(false);
            tortPanel.SetActive(true);
        }

    }
}
