using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public int activeCustomers;
    public int stockLevel;

    // Start is called before the first frame update
    public void newGame()
    {
        activeCustomers = 1;
        stockLevel = 100;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
