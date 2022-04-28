using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CookBoxCollishion : MonoBehaviour
{
    public GameObject CookingBox;
    public GameObject canvas;
    Collider2D NamedObject;
    Collider2D CB;
    string TagHolder;
    bool IsCooked;

    // Start is called before the first frame update
    void Start()
    {
        // disable the cooking slider 
        GameObject.Find("SliderCooking").GetComponent<CookingSlider>().enabled = false;

        // CB is the cookingBoxs collider
        CB = CookingBox.GetComponent<Collider2D>();

    }

    // Update is called once per frame
    void Update()
    {
        
        IsCooked = GameObject.Find("SliderCooking").GetComponent<CookingSlider>().Cooked;

        //check if the named object overlap with this box
        if (NamedObject.bounds.Intersects(CB.bounds))
        {
            Debug.Log("INMyBoxIs" + NamedObject);
            if (IsCooked == true)
            {
                CheckTag();
            }
        }
        else if(NamedObject = null)
        {
            Debug.Log("NoNamedObject");
        }
        else if (CB = null)
        {
            Debug.Log("Cb has no clue");
        }


    }

    void OnTriggerEnter2D(Collider2D col)
    {
        GameObject.Find("SliderCooking").GetComponent<CookingSlider>().enabled = true;
        Debug.Log("CookingSliderEnabled");

        Debug.Log("collide (name) : " + col.gameObject.name);
        Debug.Log("collide (tag) : " + col.gameObject.tag);

        // get collided food object name, and hold it
        string Name = col.gameObject.name;
        Debug.Log("collide name : " + col.gameObject.name);
        //get the named objects collider
        col = GameObject.Find(Name).GetComponent<Collider2D>();
        NamedObject = col;

        // set tagHolder as what the tag is 
        TagHolder = NamedObject.gameObject.tag;

        // if the game is won tag object
        if (IsCooked == true)
        {
            col.gameObject.tag = "Chopped&Cooked";
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        GameObject.Find("SliderCooking").GetComponent<CookingSlider>().enabled = false;
        Debug.Log("Deactivate");
    }

    void CheckTag()
    {
        if (NamedObject.tag == "Chopped")
        {
            this.gameObject.tag = "Chopped&Cooked";
        }
        else if (NamedObject.tag == " Chopped&Cooked")
        {
            // direct to plate box
        }
        else
        {
            //no tag
        }
    }

}
