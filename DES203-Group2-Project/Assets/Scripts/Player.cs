using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int money = 0;
    public int buildingNumber = 0;

    void Awake()
    {
        LoadPlayer();
    }

    public void newGame()
    {
        money = 0;
        buildingNumber = 0;
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
    }

    public void increaseMoney (int amount)
    {
        money += amount;
    }

    public void decreaseMoney (int amount)
    {
        money -= amount;
    }

    public void changeBuilding (int building)
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
        Vector3 position;
        position.x = data.position[0];
        position.y = data.position[1];
        position.z = data.position[2];
        transform.position = position;
    }
}
