using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{
    public int Width;
    public int Height;
    public GameObject[] prefabArray;

    public void GenerateMap()
    {
        for (int i = 0; i < Height; i++)
        {
            for (int j = 0; j < Width; j++)
            {
                if (i % 2 == 0)
                {
                    Vector3 spawnPos = new Vector3(j, i * 0.85f, 0);
                    int randomIndex = Random.Range(0, prefabArray.Length);
                    GameObject tile = Instantiate(prefabArray[randomIndex], spawnPos, Quaternion.identity, transform);
                    tile.GetComponent<SpriteRenderer>().sortingOrder = -i;
                    tile.GetComponent<Tile>().i = i;
                    tile.GetComponent<Tile>().j = j;
                }
                else
                {
                    Vector3 spawnPos = new Vector3(j+0.5f, i * 0.85f, 0);
                    int randomIndex = Random.Range(0, prefabArray.Length);
                    GameObject tile = Instantiate(prefabArray[randomIndex], spawnPos, Quaternion.identity, transform);
                    tile.GetComponent<SpriteRenderer>().sortingOrder = -i;
                    tile.GetComponent<Tile>().i = i;
                    tile.GetComponent<Tile>().j = j;
                }
                
            }
        }
        
        
    }

    public void SaveGame()
    {
        SaveLoad.SaveGame();
    }



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
