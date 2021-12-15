using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FoodClick : MonoBehaviour
{
    /* Svekla, Suhari, Vanilin, KolbasaOne, Goroh, Droji, Kaban, Kapusta, Kartoha, KolbasaTwo,
     * Limon, Chesnok, Luk, Maslo, MasloRast, Mayonez, Moloko, Morkov, Muka, Myaso, Ogurci, Olivki,
     * OlivkOil, PerecOne, PerecTwo, Petrushka, Pomidor, Priprava, Sahar, Soda, Sol, Syr, TomatPasta, Yaica*/

    Food foodC;
    Rigidbody2D rb;

    private void Start()
    {
        foodC = GameObject.FindWithTag("Food").GetComponent<Food>();

        rb = GetComponent<Rigidbody2D>();
    }
    private void OnMouseDown()
    {
        Destroy(gameObject);
        foodC.FoodCounter++;
        Debug.Log("CLICKED");

        if (gameObject.tag == "Svekla")
        {
            foodC.Svekla++;
            for (int i = 0; i < foodC.capturedFood.Length; i++)
            {
                if (foodC.capturedFood[i] == "Свекла")
                {
                    foodC.capturedFoodNums[i]++;
                    break;
                }
                else if (foodC.capturedFood[i] == null)
                {
                    foodC.capturedFood[i] = "Свекла";
                    foodC.capturedFoodNums[i]++;
                    break;
                }
                else i++;
            }

        }
        else if (gameObject.tag == "Suhari")
        {
            foodC.Suhari++;
        }
        else if (gameObject.tag == "Vanilin")
        {
            foodC.Vanilin++;
        }
        else if (gameObject.tag == "Kolbasa1")
        {
            foodC.KolbasaOne++;
        }
        else if (gameObject.tag == "Goroh")
        {
            foodC.Goroh++;
        }
        else if (gameObject.tag == "Droji")
        {
            foodC.Droji++;
        }
        else if (gameObject.tag == "Kaban")
        {
            foodC.Kaban++;
        }
        else if (gameObject.tag == "Kapusta")
        {
            foodC.Kapusta++;
        }
        else if (gameObject.tag == "Kartoha")
        {
            foodC.Kartoha++;
        }
        else if (gameObject.tag == "Kolbasa2")
        {
            foodC.KolbasaTwo++;
        }
        else if (gameObject.tag == "Limon")
        {
            foodC.Limon++;
        }
        else if (gameObject.tag == "Chesnok")
        {
            foodC.Chesnok++;
        }
        else if (gameObject.tag == "Luk")
        {
            foodC.Luk++;
            for (int i = 0; i < foodC.capturedFood.Length; i++)
            {
                if (foodC.capturedFood[i] == "Лук")
                {
                    foodC.capturedFoodNums[i]++;
                    break;
                }
                else if (foodC.capturedFood[i] == null)
                {
                    foodC.capturedFood[i] = "Лук";
                    foodC.capturedFoodNums[i]++;
                    break;
                }
                else i++;
            }
        }
        else if (gameObject.tag == "Maslo")
        {
            foodC.Maslo++;
        }
        else if (gameObject.tag == "MasloRast")
        {
            foodC.MasloRast++;
        }
        else if (gameObject.tag == "Mayonez")
        {
            foodC.Mayonez++;
        }
        else if (gameObject.tag == "Moloko")
        {
            foodC.Moloko++;
        }
        else if (gameObject.tag == "Morkov")
        {
            foodC.Morkov++;
        }
        else if (gameObject.tag == "Muka")
        {
            foodC.Muka++;
        }
        else if (gameObject.tag == "Myaso")
        {
            foodC.Myaso++;
            for (int i = 0; i < foodC.capturedFood.Length; i++)
            {
                if (foodC.capturedFood[i] == "Мясо")
                {
                    foodC.capturedFoodNums[i]++;
                    break;
                }
                else if (foodC.capturedFood[i] == null)
                {
                    foodC.capturedFood[i] = "Мясо";
                    foodC.capturedFoodNums[i]++;
                    break;
                }
                else i++;
            }
        }
        else if (gameObject.tag == "Ogurci")
        {
            foodC.Ogurci++;
        }
        else if (gameObject.tag == "Olivki")
        {
            foodC.Olivki++;
        }
        else if (gameObject.tag == "OlivkOil")
        {
            foodC.OlivkOil++;
        }
        else if (gameObject.tag == "PerecOne")
        {
            foodC.PerecOne++;
        }
        else if (gameObject.tag == "PerecTwo")
        {
            foodC.PerecTwo++;
        }
        else if (gameObject.tag == "Petrushka")
        {
            foodC.Petrushka++;
        }
        else if (gameObject.tag == "Pomidor")
        {
            foodC.Pomidor++;
        }
        else if (gameObject.tag == "Priprava")
        {
            foodC.Priprava++;
        }
        else if (gameObject.tag == "Sahar")
        {
            foodC.Sahar++;
        }
        else if (gameObject.tag == "Soda")
        {
            foodC.Soda++;
        }
        else if (gameObject.tag == "Sol")
        {
            foodC.Sol++;
        }
        else if (gameObject.tag == "Syr")
        {
            foodC.Syr++;
        }
        else if (gameObject.tag == "TomatPasta")
        {
            foodC.TomatPasta++;
        }
        else if (gameObject.tag == "Yaica")
        {
            foodC.Yaica++;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "DropZone")
        {
            Destroy(gameObject);

            Debug.Log("DESTROYED");
        }
    }

}
