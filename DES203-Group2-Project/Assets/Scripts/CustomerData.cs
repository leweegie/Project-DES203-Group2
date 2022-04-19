using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class CustomerData
{
    public int SpriteNumber;
    public int textID;
    public float[] position;

    public CustomerData(Customer customer)
    {
        textID = customer.textID;

        position = new float[3];
        position[0] = customer.transform.position.x;
        position[1] = customer.transform.position.y;
        position[2] = customer.transform.position.z;
    }

}
