using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIAppear : MonoBehaviour
{
    [SerializeField] private Button[] customButton;
    [SerializeField] private Image[] buttonImage;
    int size;
    public AudioSource audioQ;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            size = customButton.Length;
            for (int i = 0; i < size; i++)
            {
                customButton[i].enabled = true;
                buttonImage[i].enabled = true;
            }
            audioQ.Play();
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            size = customButton.Length;
            for (int i = 0; i < size; i++)
            {
                customButton[i].enabled = false;
                buttonImage[i].enabled = false;
            }

        }
    }
}
