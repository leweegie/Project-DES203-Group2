using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class CustomerData
{
    public int activeCustomer;
    public bool isCustomerActive;
    public int orderOrThanks;

    public CustomerData(CustomerManager customer)
    {
        activeCustomer = customer.activeCustomer;
        isCustomerActive = customer.isCustomerActive;
        orderOrThanks = customer.orderOrThanks;
        
        
        
        
        //textPointer = new int[5];
        //for (int i = 0; i < 5; i++)
        //{
        //    textPointer[i] = customer[i].textID;
        //}
        //textPointer[0] = customer[0].textID;


        //position = new float[3];
        //position[0] = customer.transform.position.x;
        //position[1] = customer.transform.position.y;
        //position[2] = customer.transform.position.z;
    }

}
