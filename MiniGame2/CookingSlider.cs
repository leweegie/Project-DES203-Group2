using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CookingSlider : MonoBehaviour
{
    public Slider CookSlider;
    float value;
    bool GotValue = false;
    public bool Cooked;

    void OnEnable()
    {
        Start();
    }

    // Start is called before the first frame update
    void Start()
    {
        Cooked = false;
        value = 0;
        GotValue = false;
        // repeat with delay 
        InvokeRepeating("SliderControl", 0f, 0.02f);
        Update();
    }

    // Update is called once per frame
    void Update()
    {
        // if space is pressed
        if (Input.GetKey(KeyCode.Space))
        {
            value = CookSlider.value;
            Debug.Log("space" + value);
            CookSlider.value = value;
            GotValue = true;
            Winner();

        }

        if (GotValue == true)
        {
            CookSlider.value = value;
        }
    }

    void SliderControl()
    {
        // slider + 1
        CookSlider.value += 1;

        // if value is 100 and Gotvalue is not true
        if (CookSlider.value == 100 && GotValue != true)
        {
            Debug.Log("Reached100");
            InvokeRepeating("Revers", 0f, 0.02f);
        }

    }

    void Revers()
    {
        Debug.Log("GoingDown");
        CookSlider.value -= 1;
        if (CookSlider.value == 0 && GotValue != true)
        {
            Debug.Log("Reached100");
            InvokeRepeating("SliderControl", 0f, 0.02f);
        }
    }

    void Winner()
    {
        // if value is greater than 36 and less than 44
        if (value >= 36 && value <= 44)
        {
            Cooked = true;
            Debug.Log("cooked");
        }
        else
        {
            Cooked = false;
            GotValue = false;
            Debug.Log("NoCookingYou");
        }

    }

}
