using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Customer : MonoBehaviour
{
    public int customerID;
    public int textID;
    public Text[] customerDialogue;

    void Awake()
    {
        //LoadCustomer();
        showDialogue();
    }

    public void newGame()
    {
        customerID = 0;
        textID = 0;
    }

    public void qNextText()
    {
        customerDialogue[textID].enabled = false;

        textID += 1;

    }

    public void showDialogue()
    {
        customerDialogue[textID].enabled = true;
    }
}
