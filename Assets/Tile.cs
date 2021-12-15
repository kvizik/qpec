using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum TileType { tile1, tile2, tile3, tile4, tile5 }
public class Tile : MonoBehaviour
{
    public TileType type;
    public int i;//Строка
    public int j;//Столбец
    // Start is called before the first frame update
    void Start()
    {
        
    }
    //Работает только если есть коллизия
    private void OnMouseOver()
    {
        GetComponent<SpriteRenderer>().color = Color.red;
    }
    private void OnMouseExit()
    {
        GetComponent<SpriteRenderer>().color = Color.white;
    }
    private void OnMouseDown()
    {
        Debug.Log($"Строка номер {i} столбец номер {j}.");
    }
}
