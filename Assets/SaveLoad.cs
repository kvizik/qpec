using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public static class SaveLoad
{ 
    [System.Serializable]
    public class TileSaveInfo
    {
        public float positionX;
        public float positionY;
        public int sortingIndex;
        public TileType type;
    }
    [System.Serializable]
    public class TileSave
    {
        public List<TileSaveInfo> allSavedTiles = new List<TileSaveInfo>();
    }
    public static void SaveGame()
    {
        BinaryFormatter formatter = new BinaryFormatter();
        FileStream fs = new FileStream(@"D:\Visual Studio 2010\Юнити\New Unity Project\Save.dat", FileMode.Create);

        TileSave save = new TileSave();

        GameObject map = GameObject.FindGameObjectWithTag("Map");

        for (int i = 0; i < map.transform.childCount; i++)
        {
            Transform currentChild = map.transform.GetChild(i);
            TileSaveInfo info = new TileSaveInfo();

            info.positionX = currentChild.position.x;
            info.positionY = currentChild.position.y;
            info.sortingIndex = currentChild.GetComponent<SpriteRenderer>().sortingOrder;
            info.type = currentChild.GetComponent<Tile>().type;
            save.allSavedTiles.Add(info);
        }

        formatter.Serialize(fs, save);
        fs.Close();
        Debug.Log("Saved");
    }
    public static List<TileSaveInfo> LoadGame()
    {
        TileSave load = new TileSave();
        BinaryFormatter formatter = new BinaryFormatter();
        FileStream fs = new FileStream(@"D:\Visual Studio 2010\Юнити\New Unity Project\Save.dat", FileMode.Open);
        load = (TileSave)formatter.Deserialize(fs);
        fs.Close();
        return load.allSavedTiles;
    }
}
