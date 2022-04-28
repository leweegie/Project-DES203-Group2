using System.Collections;
using System.Collections.Generic;
using System;
using Random = System.Random;
using UnityEngine;

public class CustomerSystem : MonoBehaviour
{
    public GameObject[] customerSprites;
    public int activeSprite;

    void Awake()
    {
        spawnCustomer();
    }

    public void spawnCustomer()
    {
        customerSprites[activeSprite].SetActive(true);
    }

    public void despawnCustomer()
    {
        customerSprites[activeSprite].SetActive(false);
    }

    public void qNextCustomer()
    {
        Random r = new Random();
        int rInt = r.Next(0, 6);

        activeSprite = rInt;
    }

    //public void SaveCustomers()
    //{
    //    SaveSystem.SaveCustomerData(customers);
    //}

    //public void LoadCustomers()
    //{
    //    CustomerData data = SaveSystem.LoadCustomerData();
    //    for (int i = 0; i < 5; i++)
    //    {
    //        int textPointer = data.textPointer[i];
    //        customers[i].setTextPointer(textPointer);
    //    }
    //}
}
