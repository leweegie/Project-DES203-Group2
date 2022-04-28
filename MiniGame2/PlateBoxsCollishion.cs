using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlateBoxsCollishion : MonoBehaviour
{
   
    Collider2D NamedObject;
    List<GameObject> Ingredients = new List<GameObject>();

    List<string> InBox = new List<string>();
    public int Int;
        
    public string[] allTemp;
    int count;

    string[] Ramen = { "Chiken", "Stock","Noodles" };
    string[] LobsterBisque = {"Lobster","Milk", "Algae" };
    string[] BeefSrew = { "Beef", "Carrot", "Stock", "Potato" };
    string[] Pizza = { "Flour", "Tomato", "Cheese", "Bacon" };
    string[] YeOldeGrilledCheese = { "Bread", "Cheese" };
    string[] SmileyBurger = { "Beef", "Bread", "Lettuce" };
    string[] MrWhiskersPancakes = { "Flour", "Egg", "Milk" };
    string[] MeowchiMochiIceCream = { "IceCream", "RiceFlour" };
    string[] PumkinPie = { "Pumpkin", "WheatFlour", "Milk" };

    public GameObject Pancake, GrilledCheese, Burger, Beefstew, Gloopy, PPizza;
    public GameObject finish;


    // Start is called before the first frame update
    void Start()
    {
        recipes();

        Debug.Log("this food " + string.Join(", ", LobsterBisque));
    }

    // Update is called once per frame
    void Update()
    {
        // for each gameobject in the list add it to a list
        foreach (GameObject item in Ingredients)
        {
            Debug.Log("foreach started");
            Debug.Log("Adding this ingrediant to list" + Ingredients[Int]);

            string temp;

            temp = Ingredients[Int].gameObject.name;
            Debug.Log("temp is  " + temp);
            InBox.Add(temp);
            Int++;
            Debug.Log("inbox list is " + string.Join(", ", InBox) + "int=" + Int);
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("collide (name) : " + col.gameObject.name);
        Debug.Log("collide (tag) : " + col.gameObject.tag);

        // get collided food object name, and hold it
        string Name = col.gameObject.name;
        Debug.Log("collide name : " + col.gameObject.name);

        //get the named objects collider
        col = GameObject.Find(Name).GetComponent<Collider2D>();
        // set named object as the collided object
        NamedObject = col;

        CheckTag();
    }

    void OnTriggerExit2D(Collider2D col)
    {
        GameObject.Find("SliderCooking").GetComponent<CookingSlider>().enabled = false;
        Debug.Log("Deactivate");
    }

    void CheckTag()
    {
        // check what the tag is and depending what it is tell the player to cook the food or add the ingrediant to the list
        if (NamedObject.tag == "Chopped")
        {
            Debug.Log("PleaseCook");
            
        }
        else if (NamedObject.tag == "ChoppedCooked")
        {
                Ingredients.Add(NamedObject.gameObject);
                Debug.Log("added to list " + NamedObject.gameObject.name);
                Debug.Log("first ingrediants is" + Ingredients[0]);

                // remove to start
                recipes();
        }
        else
        {
            // check tag isnt working therfore add every ingrediant to list
            Debug.Log("NoTagFound");
            Ingredients.Add(NamedObject.gameObject);
            Debug.Log("added to list " + NamedObject.gameObject.name);
            Debug.Log("first ingrediants is" + Ingredients[0]);
        }
    }

    void recipes()
    {
        // sort each of the arrays 
        Array.Sort(Ramen);
        Array.Sort(LobsterBisque);
        Array.Sort(BeefSrew);
        Array.Sort(Pizza);
        Array.Sort(YeOldeGrilledCheese);
        Array.Sort(SmileyBurger);
        Array.Sort(MrWhiskersPancakes);
        Array.Sort(MeowchiMochiIceCream);
        Array.Sort(PumkinPie);

    }

    public void PlateButton()
    {
        // turn the list into an array
        allTemp = InBox.ToArray();
        // sort the array
        Array.Sort(allTemp);
        Debug.Log("array alltemp is");
        Debug.Log(string.Join(", ", allTemp));

        Compare();
    }

    void Compare()
    {
        GameObject plated;
        GameObject canvas = GameObject.Find("Canvas");
        canvas.gameObject.SetActive(false);

        bool areEqual = allTemp.SequenceEqual(Ramen);

        bool result = allTemp.Equals(LobsterBisque);
        // attempt at comparing the array of ingrediants to the array recipes
        if (Array.Equals(allTemp, Ramen));
        {
            plated = PPizza;
        }
        if (result)
        {
            plated = Beefstew;
        }
        if (allTemp == BeefSrew)
        {
            plated = Beefstew;
        }
        if (allTemp == Pizza)
        {
            plated = PPizza;
        }
        if (allTemp == YeOldeGrilledCheese)
        {
            plated = GrilledCheese;
        }
        if (allTemp == SmileyBurger)
        {
            plated = Burger;
        }
        if (allTemp == MrWhiskersPancakes)
        {
            plated = Pancake;
        }
        if (allTemp == MeowchiMochiIceCream)
        {
            plated = Pancake;
        }
        if (allTemp == PumkinPie)
        {
            plated = Pancake;
        }
        else
        {
            // if dose not match any recipe
            plated = Gloopy;
            Debug.Log("Found gloop");
        }

        // set game objects as true to show the player
        plated.gameObject.SetActive(true);
        finish.gameObject.SetActive(true);
    }

    void FinishButton()
    {
        // load the main scene
        SceneManager.LoadScene("MainScene");
    }
}
