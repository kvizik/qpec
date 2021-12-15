using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FoodSpawner : MonoBehaviour
{
    BludoChooser bCh;
    public GameObject[] pizzaArr, omeletArr, schiArr, borschArr, olivierArr, solyankaArr, raguArr, cotletsArr, tortArr;
    private GameObject inst_obj;
    public bool stopInvk = false;
    public GameObject parentObj;
    void Start()
    {
        if (stopInvk == false)
        {
            InvokeRepeating("SpawnFood", 0.5f, 0.5f);
        }
        bCh = GameObject.FindWithTag("Chooser").GetComponent<BludoChooser>();
    }


    void StopSpawner()
    {
        CancelInvoke();
    }
    void SpawnFood()
    {
        if (bCh.currentBludo == "Пицца")
        {
            int rand = Random.Range(0, pizzaArr.Length);
            inst_obj = Instantiate(pizzaArr[rand], pizzaArr[rand].transform.position, Quaternion.identity, parentObj.transform) as GameObject;
            inst_obj.transform.position = new Vector3(Random.Range(-4.33f, 8.2f), 3.09f, 0f);
        }
        else if (bCh.currentBludo == "Омлет")
        {
            int rand = Random.Range(0, omeletArr.Length);
            inst_obj = Instantiate(omeletArr[rand], omeletArr[rand].transform.position, Quaternion.identity, parentObj.transform) as GameObject;
            inst_obj.transform.position = new Vector3(Random.Range(-4.33f, 8.2f), 3.09f, 0f);
        }
        else if (bCh.currentBludo == "Щи")
        {
            int rand = Random.Range(0, schiArr.Length);
            inst_obj = Instantiate(schiArr[rand], schiArr[rand].transform.position, Quaternion.identity, parentObj.transform) as GameObject;
            inst_obj.transform.position = new Vector3(Random.Range(-4.33f, 8.2f), 3.09f, 0f);
        }
        else if (bCh.currentBludo == "Борщ")
        {
            int rand = Random.Range(0, borschArr.Length);
            inst_obj = Instantiate(borschArr[rand], borschArr[rand].transform.position, Quaternion.identity, parentObj.transform) as GameObject;
            inst_obj.transform.position = new Vector3(Random.Range(-4.33f, 8.2f), 3.09f, 0f);
        }
        else if (bCh.currentBludo == "Оливье")
        {
            int rand = Random.Range(0, olivierArr.Length);
            inst_obj = Instantiate(olivierArr[rand], olivierArr[rand].transform.position, Quaternion.identity, parentObj.transform) as GameObject;
            inst_obj.transform.position = new Vector3(Random.Range(-4.33f, 8.2f), 3.09f, 0f);
        }
        else if (bCh.currentBludo == "Солянка")
        {
            int rand = Random.Range(0, solyankaArr.Length);
            inst_obj = Instantiate(solyankaArr[rand], solyankaArr[rand].transform.position, Quaternion.identity, parentObj.transform) as GameObject;
            inst_obj.transform.position = new Vector3(Random.Range(-4.33f, 8.2f), 3.09f, 0f);
        }
        else if (bCh.currentBludo == "Рагу")
        {
            int rand = Random.Range(0, raguArr.Length);
            inst_obj = Instantiate(raguArr[rand], raguArr[rand].transform.position, Quaternion.identity, parentObj.transform) as GameObject;
            inst_obj.transform.position = new Vector3(Random.Range(-4.33f, 8.2f), 3.09f, 0f);
        }
        else if (bCh.currentBludo == "Котлеты")
        {
            int rand = Random.Range(0, cotletsArr.Length);
            inst_obj = Instantiate(cotletsArr[rand], cotletsArr[rand].transform.position, Quaternion.identity, parentObj.transform) as GameObject;
            inst_obj.transform.position = new Vector3(Random.Range(-4.33f, 8.2f), 3.09f, 0f);
        }
        else if (bCh.currentBludo == "Торт")
        {
            int rand = Random.Range(0, tortArr.Length);
            inst_obj = Instantiate(tortArr[rand], tortArr[rand].transform.position, Quaternion.identity, parentObj.transform) as GameObject;
            inst_obj.transform.position = new Vector3(Random.Range(-4.33f, 8.2f), 3.09f, 0f);
        }
    }

    void Update()
    {
        
    }
}
