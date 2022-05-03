using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownAwake : MonoBehaviour
{
    public Player player;

    void Awake()
    {
        player.LoadPlayer();
    }
}