using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapLoader : MonoBehaviour
{
    public List<GameObject> prefabs;
    public void LoadMap()
    {
        var saveList = SaveLoad.LoadGame();
        foreach (var prefab in prefabs)
        {
            foreach (var savedTile in saveList)
            {
                if (prefab.GetComponent<Tile>().type == savedTile.type)
                {
                    Vector3 spawnPos = new Vector3(savedTile.positionX, savedTile.positionY, 0);
                    GameObject tile = Instantiate(prefab, spawnPos, Quaternion.identity, transform);
                    tile.GetComponent<SpriteRenderer>().sortingOrder = savedTile.sortingIndex;
                }
            }
        }
    }
}
