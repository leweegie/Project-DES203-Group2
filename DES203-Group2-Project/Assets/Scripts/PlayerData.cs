using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public int money;
    public int building;
    public float[] position;
    public int stock;

    public PlayerData (Player player)
    {
        money       = player.money;
        building    = player.buildingNumber;
        stock       = player.stock;

        position = new float[3];
        position[0] = player.transform.position.x;
        position[1] = player.transform.position.y;
        position[2] = player.transform.position.z;
    }
}
