using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIAppear2D : MonoBehaviour
{
    public GameObject blacksmithButton;
    public GameObject tavernButton;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            blacksmithButton.SetActive(true);
            tavernButton.SetActive(true);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            blacksmithButton.SetActive(false);
            tavernButton.SetActive(false);
        }
    }
}