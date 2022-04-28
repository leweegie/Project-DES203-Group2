using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutBoxCollishion : MonoBehaviour
{
    Collider2D temp;
    public GameObject canvas;
    bool IsCutTrue = false;
    Collider2D ThisBounds;
    Collider2D NamedObject;

    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("Slider").GetComponent<CutSlider>().enabled = false;

        ThisBounds = this.gameObject.GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        IsCutTrue = GameObject.Find("Slider").GetComponent<CutSlider>().IsCut;

        //check if the named object overlap with this box
        if (NamedObject.bounds.Intersects(ThisBounds.bounds))
        {
            if (IsCutTrue == true)
            {
                Ingredients();
                Debug.Log("check the ingrediants");
            }

        }

    }

    void OnTriggerEnter2D(Collider2D col)
    {

        GameObject.Find("Slider").GetComponent<CutSlider>().enabled = true;
        Debug.Log("SliderEnabled");

        // move chopped to after game or to prefabs
        //col.gameObject.tag = "Chopped";


        Debug.Log("collide (name) : " + col.gameObject.name);
        Debug.Log("collide (tag) : " + col.gameObject.tag);
        temp = col;

        // get collided object name, and hold it
        string Name = col.gameObject.name;

        Debug.Log("collide name : " + col.gameObject.name);
        //get the named objects collider
        col = GameObject.Find(Name).GetComponent<Collider2D>();
        NamedObject = col;

    }

    void OnTriggerExit2D(Collider2D col)
    {
        GameObject.Find("Slider").GetComponent<CutSlider>().enabled = false;
        Debug.Log("Deactivate");
    }

    void Ingredients()
    {
        // if temps name is chicken
        if (temp.gameObject.name == "Chicken")
        {
            // replace chicken with chicken prfab from Resources
            GameObject Placeholdder = Instantiate(Resources.Load("Chicken") as GameObject, temp.transform.position, Quaternion.identity);
            Placeholdder.transform.SetParent(canvas.transform);
            Destroy(temp.gameObject);

            // add tag chopped to item
            this.gameObject.tag = "Chopped";
        }
        if (temp.gameObject.name == "Beef")
        {

            GameObject Placeholdder = Instantiate(Resources.Load("Beef") as GameObject, temp.transform.position, Quaternion.identity);
            Placeholdder.transform.SetParent(canvas.transform);
            Destroy(temp.gameObject);
            Placeholdder.gameObject.tag = "Chopped";
        }
        if (temp.gameObject.name == "Lobster")
        {

            GameObject Placeholdder = Instantiate(Resources.Load("Lobster") as GameObject, temp.transform.position, Quaternion.identity);
            Placeholdder.transform.SetParent(canvas.transform);
            Destroy(temp.gameObject);
            Placeholdder.gameObject.tag = "Chopped";
        }
        if (temp.gameObject.name == "Carrot")
        {

            GameObject Placeholdder = Instantiate(Resources.Load("Carrot") as GameObject, temp.transform.position, Quaternion.identity);
            Placeholdder.transform.SetParent(canvas.transform);
            Destroy(temp.gameObject);
            Placeholdder.gameObject.tag = "Chopped";
        }
        if (temp.gameObject.name == "Pumpkin")
        {

            GameObject Placeholdder = Instantiate(Resources.Load("Pumpkin") as GameObject, temp.transform.position, Quaternion.identity);
            Placeholdder.transform.SetParent(canvas.transform);
            Destroy(temp.gameObject);
            Placeholdder.gameObject.tag = "Chopped";
        }
        if (temp.gameObject.name == "Tomato")
        {

            GameObject Placeholdder = Instantiate(Resources.Load("Tomato") as GameObject, temp.transform.position, Quaternion.identity);
            Placeholdder.transform.SetParent(canvas.transform);
            Destroy(temp.gameObject);
            Placeholdder.gameObject.tag = "Chopped";
        }
        if (temp.gameObject.name == "Flour")
        {

            GameObject Placeholdder = Instantiate(Resources.Load("Flour") as GameObject, temp.transform.position, Quaternion.identity);
            Placeholdder.transform.SetParent(canvas.transform);
            Destroy(temp.gameObject);
            Placeholdder.gameObject.tag = "Chopped";
        }
        if (temp.gameObject.name == "Rice Flour")
        {

            GameObject Placeholdder = Instantiate(Resources.Load("RiceFour") as GameObject, temp.transform.position, Quaternion.identity);
            Placeholdder.transform.SetParent(canvas.transform);
            Destroy(temp.gameObject);
            Placeholdder.gameObject.tag = "Chopped";
        }
        if (temp.gameObject.name == "Potato")
        {

            GameObject Placeholdder = Instantiate(Resources.Load("Potato") as GameObject, temp.transform.position, Quaternion.identity);
            Placeholdder.transform.SetParent(canvas.transform);
            Destroy(temp.gameObject);
            Placeholdder.gameObject.tag = "Chopped";
        }
        if (temp.gameObject.name == "Lettuce")
        {

            GameObject Placeholdder = Instantiate(Resources.Load("Lettuce") as GameObject, temp.transform.position, Quaternion.identity);
            Placeholdder.transform.SetParent(canvas.transform);
            Destroy(temp.gameObject);
            Placeholdder.gameObject.tag = "Chopped";
        }
        if (temp.gameObject.name == "Stock")
        {

            GameObject Placeholdder = Instantiate(Resources.Load("Stock") as GameObject, temp.transform.position, Quaternion.identity);
            Placeholdder.transform.SetParent(canvas.transform);
            Destroy(temp.gameObject);
            Placeholdder.gameObject.tag = "Chopped";
        }
        if (temp.gameObject.name == "Bread")
        {

            GameObject Placeholdder = Instantiate(Resources.Load("Bread") as GameObject, temp.transform.position, Quaternion.identity);
            Placeholdder.transform.SetParent(canvas.transform);
            Destroy(temp.gameObject);
            Placeholdder.gameObject.tag = "Chopped";
        }
        if (temp.gameObject.name == "Milk")
        {

            GameObject Placeholdder = Instantiate(Resources.Load("Milk") as GameObject, temp.transform.position, Quaternion.identity);
            Placeholdder.transform.SetParent(canvas.transform);
            Destroy(temp.gameObject);
            Placeholdder.gameObject.tag = "Chopped";
        }
        if (temp.gameObject.name == "Icecream")
        {

            GameObject Placeholdder = Instantiate(Resources.Load("IceCream") as GameObject, temp.transform.position, Quaternion.identity);
            Placeholdder.transform.SetParent(canvas.transform);
            Destroy(temp.gameObject);
            Placeholdder.gameObject.tag = "Chopped";
        }
        if (temp.gameObject.name == "Egg")
        {

            GameObject Placeholdder = Instantiate(Resources.Load("Egg") as GameObject, temp.transform.position, Quaternion.identity);
            Placeholdder.transform.SetParent(canvas.transform);
            Destroy(temp.gameObject);
            Placeholdder.gameObject.tag = "Chopped";
        }
        if (temp.gameObject.name == "Cheese")
        {

            GameObject Placeholdder = Instantiate(Resources.Load("Cheese") as GameObject, temp.transform.position, Quaternion.identity);
            Placeholdder.transform.SetParent(canvas.transform);
            Destroy(temp.gameObject);
            Placeholdder.gameObject.tag = "Chopped";
        }
        if (temp.gameObject.name == "Algae")
        {

            GameObject Placeholdder = Instantiate(Resources.Load("Algae") as GameObject, temp.transform.position, Quaternion.identity);
            Placeholdder.transform.SetParent(canvas.transform);
            Destroy(temp.gameObject);
            Placeholdder.gameObject.tag = "Chopped";
        }
        else
        {
            // null
        }
    }

}
