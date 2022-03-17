using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLocationButton : MonoBehaviour
{
    public GameObject blacksmithButton;
    public GameObject tavernButton;

    // Start is called before the first frame update
    public void triggerButtons()
    {
        if (blacksmithButton.activeSelf == true)
        {
            blacksmithButton.SetActive(false);
        }
        else
        {
            blacksmithButton.SetActive(true);
        }
        if (tavernButton.activeSelf == true)
        {
            tavernButton.SetActive(false);
        }
        else
        {
            tavernButton.SetActive(true);
        }
    }
}
