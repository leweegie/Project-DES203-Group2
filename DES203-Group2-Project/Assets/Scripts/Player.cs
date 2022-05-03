using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public int money;
    public int buildingNumber;
    public int stock;
    public CustomerManager customer;

    void Awake()
    {
        LoadPlayer();
    }

    void Update()
    {
        if (stock == 0)
        {
            SavePlayer();
            StartCoroutine(_wait());
        }
    }

    IEnumerator _wait()
    {
        yield return new WaitForSeconds(1);
        loadSceneReceipt();
    }

    IEnumerator _wait2()
    {
        yield return new WaitForSeconds(1);
        loadSceneNewDay();
    }

    public void loadSceneReceipt()
    {
        customer.isCustomerActive = false;
        SceneManager.LoadScene(5);
    }

    public void loadSceneNewDay()
    {
        customer.isCustomerActive = true;
        SceneManager.LoadScene(1);
    }

    public void RefillStock()
    {
        if (money >= 3 && stock <= 90)
        {
            money -= 3;
            stock += 10;
            SavePlayer();
        }
    }

    public void newDay()
    {
        if (stock > 0)
        {
            Vector3 position;
            position.x = 1.2347f;
            position.y = 2.6764f;
            position.z = 0.0f;
            transform.position = position;
            SavePlayer();
            StartCoroutine(_wait2());
        }
    }

    public void newGame()
    {
        money = 0;
        buildingNumber = 0;
        stock = 100;
        Vector3 position;
        position.x = 1.2347f;
        position.y = 2.6764f;
        position.z = 0.0f;
        transform.position = position;
        SavePlayer();
    }

    public void drinkOrderComplete()
    {
        increaseMoney(10);
        stock -= 20;
    }


    public void increaseMoney(int amount)
    {
        money += amount;
    }

    public void decreaseMoney(int amount)
    {
        money -= amount;
    }

    public void changeBuilding(int building)
    {
        buildingNumber = building;
    }

    public void SavePlayer()
    {
        SaveSystem.SavePlayerData(this);
    }

    public void LoadPlayer()
    {
        PlayerData data = SaveSystem.LoadPlayerData();

        money = data.money;
        buildingNumber = data.building;
        stock = data.stock;
        Vector3 position;
        position.x = data.position[0];
        position.y = data.position[1];
        position.z = data.position[2];
        transform.position = position;
    }
}