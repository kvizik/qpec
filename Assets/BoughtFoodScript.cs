using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoughtFoodScript : MonoBehaviour
{
    Food foodC;
    CartScript cartS;
    BludoChooser bChooser;
    public Text Muka, Sol, Droji, TomatPasta, KolbasaTwo, OlivkOil, Syr, MasloRast, Yaica, Moloko, Myaso, Svekla, Luk, Morkov, Kapusta, Kartofel, KolbasaOne, Ogurci, Goroh, Mayonez, Chesnok, Olivki, Limon, Kaban, PerecOne, Tomat, Vanilin, Sahar, Suhari;
    void Start()
    {
        foodC = GameObject.FindWithTag("Food").GetComponent<Food>();
        cartS = GameObject.FindWithTag("Cart").GetComponent<CartScript>();
        bChooser = GameObject.FindWithTag("Chooser").GetComponent<BludoChooser>();
    }

    void Update()
    {
        Muka.text = foodC.Muka.ToString();
        Sol.text = foodC.Sol.ToString();
        Droji.text = foodC.Droji.ToString();
        TomatPasta.text = foodC.TomatPasta.ToString();
        KolbasaTwo.text = foodC.KolbasaTwo.ToString();
        OlivkOil.text = foodC.OlivkOil.ToString();
        Syr.text = foodC.Syr.ToString();
        MasloRast.text = foodC.MasloRast.ToString();
        Yaica.text = foodC.Yaica.ToString();
        Moloko.text = foodC.Moloko.ToString();
        Myaso.text = foodC.Myaso.ToString();
        Svekla.text = foodC.Svekla.ToString();
        Luk.text = foodC.Luk.ToString();
        Morkov.text = foodC.Morkov.ToString();
        Kapusta.text = foodC.Kapusta.ToString();
        Kartofel.text = foodC.Kartoha.ToString();
        KolbasaOne.text = foodC.KolbasaOne.ToString();
        Ogurci.text = foodC.Ogurci.ToString();
        Goroh.text = foodC.Goroh.ToString();
        Mayonez.text = foodC.Mayonez.ToString();
        Chesnok.text = foodC.Chesnok.ToString();
        Olivki.text = foodC.Olivki.ToString();
        Limon.text = foodC.Limon.ToString();
        Kaban.text = foodC.Kaban.ToString();
        PerecOne.text = foodC.PerecOne.ToString();
        Tomat.text = foodC.Pomidor.ToString();
        Vanilin.text = foodC.Vanilin.ToString();
        Sahar.text = foodC.Sahar.ToString();
        Suhari.text = foodC.Suhari.ToString();
    }

    public void ClackClack(GameObject q)
    {
        Debug.Log("BackBackBack");

        if (q.tag == "Svekla")
        {
            if (foodC.Svekla >= 1)
            {
                foodC.Svekla--;
                cartS.price -= 10;
            }

        }
        else if (q.tag == "Suhari")
        {
            if (foodC.Suhari >= 1)
            {
                foodC.Suhari--;
                cartS.price -= 10;
            }
        }
        else if (q.tag == "Vanilin")
        {
            if (foodC.Vanilin >= 1)
            {
                foodC.Vanilin--;
                cartS.price -= 10;
            }
        }
        else if (q.tag == "Kolbasa1")
        {
            if (foodC.KolbasaOne >= 1)
            {
                cartS.price -= 10;
                foodC.KolbasaOne--;
            }
        }
        else if (q.tag == "Goroh")
        {
            if (foodC.Goroh >= 1)
            {
                foodC.Goroh--;
                cartS.price -= 10;
            }
        }
        else if (q.tag == "Droji")
        {
            if (foodC.Droji >= 1)
            {
                foodC.Droji--;
                cartS.price -= 10;
            }
        }
        else if (q.tag == "Kaban")
        {
            if (foodC.Kaban >= 1)
            {
                foodC.Kaban--;
                cartS.price -= 10;
            }
        }
        else if (q.tag == "Kapusta")
        {
            if (foodC.Kapusta >= 1)
            {
                foodC.Kapusta--;
                cartS.price -= 10;
            }
        }
        else if (q.tag == "Kartoha")
        {
            if (foodC.Kartoha >= 1)
            {
                foodC.Kartoha--;
                cartS.price -= 10;
            }
        }
        else if (q.tag == "Kolbasa2")
        {
            if (foodC.KolbasaTwo >= 1)
            {
                foodC.KolbasaTwo--;
                cartS.price -= 10;
            }
        }
        else if (q.tag == "Limon")
        {
            if (foodC.Limon >= 1)
            {
                cartS.price -= 10;
                foodC.Limon--;
            }
        }
        else if (q.tag == "Chesnok")
        {
            if (foodC.Chesnok >= 1)
            {
                foodC.Chesnok--;
                cartS.price -= 10;
            }
        }
        else if (q.tag == "Luk")
        {
            if (foodC.Luk >= 1)
            {
                foodC.Luk--;
                cartS.price -= 10;
            }
        }
        else if (q.tag == "Maslo")
        {
            if (foodC.Maslo >= 1)
            {
                foodC.Maslo--;
                cartS.price -= 10;
            }
        }
        else if (q.tag == "MasloRast")
        {
            if (foodC.MasloRast >= 1)
            {
                foodC.MasloRast--;
                cartS.price -= 10;
            }
        }
        else if (q.tag == "Mayonez")
        {
            if (foodC.Mayonez >= 1)
            {
                foodC.Mayonez--;
                cartS.price -= 10;
            }
        }
        else if (q.tag == "Moloko")
        {
            if (foodC.Moloko >= 1)
            {
                foodC.Moloko--;
                cartS.price -= 10;
            }
        }
        else if (q.tag == "Morkov")
        {
            if (foodC.Morkov >= 1)
            {
                foodC.Morkov--;
                cartS.price -= 10;
            }
        }
        else if (q.tag == "Muka")
        {
            if (foodC.Muka >= 1)
            {
                foodC.Muka--;
                cartS.price -= 10;
            }
        }
        else if (q.tag == "Myaso")
        {
            if (foodC.Myaso >= 1)
            {
                foodC.Myaso--;
                cartS.price -= 10;
            }
        }
        else if (q.tag == "Ogurci")
        {
            if (foodC.Ogurci >= 1)
            {
                foodC.Ogurci--;
                cartS.price -= 10;
            }
        }
        else if (q.tag == "Olivki")
        {
            if (foodC.Olivki >= 1)
            {
                cartS.price -= 10;

                foodC.Olivki--;
            }
        }
        else if (q.tag == "OlivkOil")
        {
            if (foodC.OlivkOil >= 1)
            {
                foodC.OlivkOil--;
                cartS.price -= 10;
            }
        }
        else if (q.tag == "PerecOne")
        {
            if (foodC.PerecOne >= 1)
            {
                foodC.PerecOne--;
                cartS.price -= 10;
            }
        }
        else if (q.tag == "PerecTwo")
        {
            if (foodC.PerecTwo >= 1)
            {
                foodC.PerecTwo--;
                cartS.price -= 10;
            }
        }
        else if (q.tag == "Petrushka")
        {
            if (foodC.Petrushka >= 1)
            {
                foodC.Petrushka--;
                cartS.price -= 10;
            }
        }
        else if (q.tag == "Pomidor")
        {
            if (foodC.Pomidor >= 1)
            {
                foodC.Pomidor--;
                cartS.price -= 10;
            }
        }
        else if (q.tag == "Priprava")
        {
            if (foodC.Priprava >= 1)
            {
                foodC.Priprava--;
                cartS.price -= 10;
            }
        }
        else if (q.tag == "Sahar")
        {
            if (foodC.Sahar >= 1)
            {
                foodC.Sahar--;
                cartS.price -= 10;
            }
        }
        else if (q.tag == "Soda")
        {
            if (foodC.Soda >= 1) { 
                cartS.price -= 10;
                foodC.Soda--;
        }
        }
        else if (q.tag == "Sol")
        {
            if (foodC.Sol >= 1)
            {
                foodC.Sol--;
                cartS.price -= 10;
            }
            }
            else if (q.tag == "Syr")
        {
            if (foodC.Syr >= 1)
            {
                foodC.Syr--;
                cartS.price -= 10;
            }
            }
            else if (q.tag == "TomatPasta")
        {
            if (foodC.TomatPasta >= 1)
            {
                foodC.TomatPasta--;
                cartS.price -= 10;
            }
            }
            else if (q.tag == "Yaica")
        {
            if (foodC.Yaica >= 1)
            {
                foodC.Yaica--;
                cartS.price -= 10;
            }
            }
        }
}
