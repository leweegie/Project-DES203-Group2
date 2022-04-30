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
    public bool isCustomerActive;
    public int customerCount;
    public int orderOrThanks;
    public GameObject[] replyButtons;
    public AudioSource NewCustomerAudio;
    public GameObject DialogueObject;


    // Update is called once per frame
    void Awake()
    {
        if (isCustomerActive == true)
        {
            LoadCustomer();
            Debug.Log("Show Customer");
            ShowCustomer();
        }
    }

    void Update()
    {
        if (isCustomerActive == true)
        {
            customerCount = 1;
        }
        else
        {
            customerCount = 0;
        }
    }


    public void NextCustomer()
    {
        StartCoroutine(_ShowCustomer());
    }

    public void ShowCustomer()
    {
        customerSprite[activeCustomer].SetActive(true);
        DialogueObject.SetActive(true);
        ShowDialogue(orderOrThanks);
    }

    IEnumerator _ShowCustomer()
    {
        yield return new WaitForSeconds(3);
        ShowCustomer();
        NewCustomerAudio.Play();
    }

    public void ShowDialogue(int checker)
    {
        if (checker == 1)
        {
            Debug.Log("1");
            Random r = new Random();
            int rInt = r.Next(0, 3);
            orderRecieved[0].enabled = false;
            orderDialogue[rInt].enabled = true;
            replyButtons[0].SetActive(true);
        }
        if (checker == 2)
        {
            Debug.Log("2");
            Random r = new Random();
            int rInt = r.Next(0, 3);
            orderDialogue[rInt].enabled = false;
            orderRecieved[rInt].enabled = true;
            replyButtons[1].SetActive(true);
        }
    }

    public void OrderPlaced()
    {
        orderOrThanks = 2;
    }

    public void OrderRecieved()
    {
        customerSprite[activeCustomer].SetActive(false);
        orderOrThanks = 1;
        for (int i = 0; i < 3; i++)
        {
            orderDialogue[i].enabled = false;
            orderRecieved[i].enabled = false;
        }
    }

    public void DeclineOrder()
    {
        OrderRecieved();
        qNextCustomer();
        NextCustomer();
    }

    public void qNextCustomer()
    {
        Random r = new Random();
        int rInt = r.Next(0, 6);
        int rPos = r.Next(0, 6);

        Debug.Log(rPos);

        float xModifier = rPos;
        xModifier = -171.0f + (xModifier * 175.0f);


        activeCustomer = rInt;

        Vector3 spritePosition;
        spritePosition.x = xModifier;
        spritePosition.y = 18.0f;
        spritePosition.z = 0.0f;

        customerSprite[rInt].transform.localPosition = spritePosition;
    }

    public void NewGame()
    {
        Random r = new Random();
        int rInt = r.Next(0, 6);
        activeCustomer = rInt;
        isCustomerActive = true;
        orderOrThanks = 1;
        SaveCustomer();
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
