using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int money = 0;
    public int buildingNumber = 0;

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
        SaveSystem.SavePlayer(this);
    }

    public void LoadPlayer()
    {
        PlayerData data = SaveSystem.LoadPlayer();

        money = data.money;
        buildingNumber = data.building;
        Vector3 position;
        position.x = data.position[0];
        position.y = data.position[1];
        position.z = data.position[2];
        transform.position = position;
    }
}
