using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerSystem : MonoBehaviour
{
    public GameObject[] customers;
    public int customerNumber = 0;

    void Awake()
    {
        spawnCustomer();
    }

    public void spawnCustomer()
    {
        customers[customerNumber].SetActive(true);
    }

    public void despawnCustomer()
    {
        customers[customerNumber].SetActive(false);
    }

    public void qNextCustomer()
    {
        customerNumber += 1;
    }
}
