using System.Collections;
using System.Collections.Generic;
using System;
using Random = System.Random;
using UnityEngine;
using UnityEngine.UI;

public class CustomerManager : MonoBehaviour
{
    public GameObject[] customerSprite;
    public int activeCustomer;
    public Text[] orderDialogue;
    public Text[] orderRecieved;
    public bool isCustomerActive = true;
    public int orderOrThanks = 1;

    // Update is called once per frame
    void Awake()
    {
        if (isCustomerActive == true)
        {
            LoadCustomer();
            Debug.Log("Show Customer");
            customerSprite[activeCustomer].SetActive(true);
            ShowDialogue(orderOrThanks);
        }
    }

    public void ShowDialogue(int checker)
    {
        if (checker == 1)
        {
            Random r = new Random();
            int rInt = r.Next(0, 1);
            orderDialogue[rInt].enabled = true;
        }
        if (checker == 2)
        {
            Random r = new Random();
            int rInt = r.Next(0, 1);
            orderDialogue[rInt].enabled = true;
        }
    }

    public void OrderPlaced()
    {
        orderOrThanks = 2;
    }

    public void OrderRecieved()
    {
        orderOrThanks = 1;
    }

    public void qNextCustomer()
    {
        Random r = new Random();
        int rInt = r.Next(0, 6);

        activeCustomer = rInt;
    }

    public void SaveCustomer()
    {
        SaveSystem.SaveCustomerData(this);
    }

    public void LoadCustomer()
    {
        CustomerData data = SaveSystem.LoadCustomerData();
        activeCustomer = data.activeCustomer;
        isCustomerActive = data.isCustomerActive;
        orderOrThanks = data.orderOrThanks;
    }

}
