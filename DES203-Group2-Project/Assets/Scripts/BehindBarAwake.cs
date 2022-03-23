using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BehindBarAwake : MonoBehaviour
{
    public Player player;
    public TextMeshProUGUI coinCount;

    void Awake()
    {
        player.LoadPlayer();
        coinCount.text = player.money.ToString();
    }
}
