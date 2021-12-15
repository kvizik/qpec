using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BludoChooser : MonoBehaviour
{
    public string[] bludos = { "�����", "����", "����", "�����", "�������", "������", "��", "�������", "����" };
    public Sprite[] bludoSpriteList;
    public Sprite[] ingrSpriteList;
    public GameObject[] ingrPrefabs;
    string[] ingrs = {"������", "������", "�����", "�������", "�������", "���������", "������� �������", "�������� �������", "�����", "���",
        "�����", "����� ������������", "�������", "������", "�������", "����", "����", "������", "������", "����� ���������",
        "����� ������", "����� ����������","��������", "�������", "��������", "�����", "����", "����", "������", "������",
        "���", "�������� �����", "�������", "����"};
    public List<string> neededIngr = new List<string>();
    public string currentBludo;
    public GameObject ingrsPanel;
    public GameObject pizzaPanel, omeletPanel, schiPanel, borschPanel, olivierPanel, solyankaPanel, raguPanel, cotletsPanel, tortPanel;

    
    void Update()
    {
        if (currentBludo == "�����")
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

        else if (currentBludo == "�����")
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
        else if (currentBludo == "��")
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
        else if (currentBludo == "����")
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
        else if (currentBludo == "������")
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
        else if (currentBludo == "�������")
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
        else if (currentBludo == "����")
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
        else if (currentBludo == "�������")
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
        else if (currentBludo == "����")
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
