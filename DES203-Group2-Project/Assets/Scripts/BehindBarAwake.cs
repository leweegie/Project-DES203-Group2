using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BehindBarAwake : MonoBehaviour
{
    public Player player;
    public CustomerManager customerManager;
    public TextMeshProUGUI coinCount;
    public TextMeshProUGUI stockLevel;
    public TextMeshProUGUI customerCount;

    void Awake()
    {
        player.LoadPlayer();
        customerManager.LoadCustomer();
        coinCount.text = player.money.ToString();
        stockLevel.text = player.stock.ToString() + "%";
        customerCount.text = customerManager.customerCount.ToString();
    }

    void Update()
    {
        coinCount.text = player.money.ToString();
        stockLevel.text = player.stock.ToString() + "%";
        customerCount.text = customerManager.customerCount.ToString();
    }
}
