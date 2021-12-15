using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FoodBackScript : MonoBehaviour
{
    Food foodC;
    void Start()
    {
        foodC = GameObject.FindWithTag("Food").GetComponent<Food>();

    }

    public void ClackClack(GameObject q)
    {
        Debug.Log("BackBackBack");

        if (q.tag == "Svekla")
        {
            if (foodC.Svekla >= 1)
                foodC.Svekla--;
        }
        else if (q.tag == "Suhari")
        {
            if (foodC.Suhari >= 1)
                foodC.Suhari--;
        }
        else if (q.tag == "Vanilin")
        {
            if (foodC.Vanilin >= 1)
                foodC.Vanilin--;
        }
        else if (q.tag == "Kolbasa1")
        {
            if (foodC.KolbasaOne >= 1)
                foodC.KolbasaOne--;
        }
        else if (q.tag == "Goroh")
        {
            if (foodC.Goroh >= 1)
                foodC.Goroh--;
        }
        else if (q.tag == "Droji")
        {
            if (foodC.Droji >= 1)
                foodC.Droji--;
        }
        else if (q.tag == "Kaban")
        {
            if (foodC.Kaban >= 1)
                foodC.Kaban--;
        }
        else if (q.tag == "Kapusta")
        {
            if (foodC.Kapusta >= 1)
                foodC.Kapusta--;
        }
        else if (q.tag == "Kartoha")
        {
            if (foodC.Kartoha >= 1)
                foodC.Kartoha--;
        }
        else if (q.tag == "Kolbasa2")
        {
            if (foodC.KolbasaTwo >= 1)
                foodC.KolbasaTwo--;
        }
        else if (q.tag == "Limon")
        {
            if (foodC.Limon >= 1)
                foodC.Limon--;
        }
        else if (q.tag == "Chesnok")
        {
            if (foodC.Chesnok >= 1)
                foodC.Chesnok--;
        }
        else if (q.tag == "Luk")
        {
            if (foodC.Luk >= 1)
                foodC.Luk--;
        }
        else if (q.tag == "Maslo")
        {
            if (foodC.Maslo >= 1)
                foodC.Maslo--;
        }
        else if (q.tag == "MasloRast")
        {
            if (foodC.MasloRast >= 1)
                foodC.MasloRast--;
        }
        else if (q.tag == "Mayonez")
        {
            if (foodC.Mayonez >= 1)
                foodC.Mayonez--;
        }
        else if (q.tag == "Moloko")
        {
            if (foodC.Moloko >= 1)
                foodC.Moloko--;
        }
        else if (q.tag == "Morkov")
        {
            if (foodC.Morkov >= 1)
                foodC.Morkov--;
        }
        else if (q.tag == "Muka")
        {
            if (foodC.Muka >= 1)
                foodC.Muka--;
        }
        else if (q.tag == "Myaso")
        {
            if (foodC.Myaso >= 1)
                foodC.Myaso--;
        }
        else if (q.tag == "Ogurci")
        {
            if (foodC.Ogurci >= 1)
                foodC.Ogurci--;
        }
        else if (q.tag == "Olivki")
        {
            if (foodC.Olivki >= 1)
                foodC.Olivki--;
        }
        else if (q.tag == "OlivkOil")
        {
            if (foodC.OlivkOil >= 1)
                foodC.OlivkOil--;
        }
        else if (q.tag == "PerecOne")
        {
            if (foodC.PerecOne >= 1)
                foodC.PerecOne--;
        }
        else if (q.tag == "PerecTwo")
        {
            if (foodC.PerecTwo >= 1)
                foodC.PerecTwo--;
        }
        else if (q.tag == "Petrushka")
        {
            if (foodC.Petrushka >= 1)
                foodC.Petrushka--;
        }
        else if (q.tag == "Pomidor")
        {
            if (foodC.Pomidor >= 1)
                foodC.Pomidor--;
        }
        else if (q.tag == "Priprava")
        {
            if (foodC.Priprava >= 1)
                foodC.Priprava--;
        }
        else if (q.tag == "Sahar")
        {
            if (foodC.Sahar >= 1)
                foodC.Sahar--;
        }
        else if (q.tag == "Soda")
        {
            if (foodC.Soda >= 1)
                foodC.Soda--;
        }
        else if (q.tag == "Sol")
        {
            if (foodC.Sol >= 1)
                foodC.Sol--;
        }
        else if (q.tag == "Syr")
        {
            if (foodC.Syr >= 1)
                foodC.Syr--;
        }
        else if (q.tag == "TomatPasta")
        {
            if (foodC.TomatPasta >= 1)
                foodC.TomatPasta--;
        }
        else if (q.tag == "Yaica")
        {
            if (foodC.Yaica >= 1)
                foodC.Yaica--;
        }
    }

    

}
