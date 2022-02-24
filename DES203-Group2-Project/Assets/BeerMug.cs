using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeerMug : MonoBehaviour
{
    public GameObject BeerMugLocation;
    public GameObject[] BeerPostion;
    int current = 0;
    public GameObject Broken;
    Time pour;

    // Start is called before the first frame update
    public void Start()
    {
        // set beer mugs location to location one
        BeerMugLocation.transform.position = BeerPostion[current].transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            current--;
            BeerMugLocation.transform.position = BeerPostion[current].transform.position;
            Debug.Log("Leftmovement");
            
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            current++;
            BeerMugLocation.transform.position = BeerPostion[current].transform.position;
            Debug.Log("Rightmovement");
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("PoorPiant");
            // change sprite or play animation
        }

    }
}
