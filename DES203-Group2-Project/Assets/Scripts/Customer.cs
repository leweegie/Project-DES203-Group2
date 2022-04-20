using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Customer : MonoBehaviour
{
    public int customerID;
    public int textID;
    public Text[] loreDialogue;

    void Awake()
    {
//        LoadCustomer();
        showDialogue();
    }

    public void newGame()
    {
        //customerID = 0;
        textID = 0;
//        SaveCustomer();
    }

    public void setTextPointer(int p)
    {
        textID = p;
    }

    public void qNextText()
    {
        loreDialogue[textID].enabled = false;

        textID += 1;

    }

    public void showDialogue()
    {
        loreDialogue[textID].enabled = true;
    }

    //public void SaveCustomer()
    //{
    //    SaveSystem.SaveCustomerData(this);
    //}

    //public void LoadCustomer()
    //{
    //    CustomerData data = SaveSystem.LoadCustomerData();

    //    textID = data.textPointer[customerID];
    //}
}
