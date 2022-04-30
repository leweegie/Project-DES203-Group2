using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CutSlider : MonoBehaviour
{
    public Slider SliderCut;
    float value;
    bool GotValue = false;
    public bool IsCut;

    void OnEnable()
    {
        Start();
    }

    // Start is called before the first frame update
    void Start()
    {
        IsCut = false;
        value = 0;
        GotValue = false;
        InvokeRepeating("SliderControl", 0f, 0.02f);
        Update();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.Space))
        {
            value = SliderCut.value;
            Debug.Log("space"+ value);
            SliderCut.value = value;
            GotValue = true;
            Winner();

        }

        if (GotValue == true)
        {
            SliderCut.value = value;
        }
    }

    void SliderControl()
    {
      SliderCut.value += 1;
        
        if (SliderCut.value == 100 && GotValue != true)
        {
           Debug.Log("Reached100");
            InvokeRepeating("Revers", 0f, 0.02f);
        }
        
    }

    void Revers()
    {
       Debug.Log("GoingDown");
                SliderCut.value -= 1;
        if (SliderCut.value == 0 && GotValue != true)
        {
            Debug.Log("Reached100");
            InvokeRepeating("SliderControl", 0f, 0.02f);
        }
    }

    void Winner()
    {
        if (value >= 36 && value <= 44 )
        {
            IsCut = true;
            Debug.Log("Iscut");
        }
       else
        {
            IsCut = false;
            GotValue = false;
            Debug.Log("NoCutForYou");
        }
        
    }
}
