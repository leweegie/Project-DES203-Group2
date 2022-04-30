using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MiniGame : MonoBehaviour
{

    public GameObject BeerMug;
    public GameObject[] BeerPostions;
    public GameObject TrayLocation;
    public GameObject BeerPrefab;
    public GameObject BeerPour;
    public GameObject finishButton;
    GameObject clone;    
    bool KeyPressed = false;
    int current = 0;
    float PourTime;
    float GameTime;
    float BeerLevel;
    ArrayList Drinks = new ArrayList();

    // Start is called before the first frame update
    public void Start()
    {
        // set beer mugs location to location one
        BeerMug.transform.position = BeerPostions[current].transform.position;

        GameTime -= Time.time;

        BeerMug.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            BeerMug.SetActive(true);
            Debug.Log("letThereBeBeer");
        }

        if (Input.GetKeyDown(KeyCode.A))
        { 
            current--;
            BeerMug.transform.position = BeerPostions[current].transform.position;
            Debug.Log("Leftmovement");
            PourTime = 0f;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            clone = (GameObject)Instantiate(BeerPour, BeerPostions[current].transform.parent.position, Quaternion.identity);
            
            KeyPressed = true;
            Timer();

        }
        else if (Input.GetKeyUp(KeyCode.S))
        {
         GameObject.Destroy(clone);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            current++;
            BeerMug.transform.position = BeerPostions[current].transform.position;
            Debug.Log("Rightmovement");
            PourTime = 0f;

        }
        
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            BeerLevel = PourTime;

            BeerMug.transform.position = TrayLocation.transform.position;

            if (BeerLevel <= 4)
            {
                //Poor Pour
                Debug.Log("poorPour");
            }
            else if (BeerLevel >= 4.1 || BeerLevel <= 8)
            {
                // avrage pour
                Debug.Log("AvragePour");
            }
            else if (BeerLevel >= 8)
            {
                // good pour 
                Debug.Log("goodPour");
            }

            SaveDrink();

            PourTime = 0f;
        }

        if (GameTime > 120)
        {
            // what do we want this to do?
            Debug.Log("TimeUp");
        }

        if (PourTime > 10)
        {
            BeerMug.SetActive(false);
            Debug.Log("PintSpilled");
        }
    }

    void Timer()
    {

        if (KeyPressed == true)
        {
            PourTime += Time.deltaTime;
            Debug.Log("key pressed time start");

        }
        else
        {
            KeyPressed = false;
            Debug.Log("key pressed time end");
            PourTime = Time.deltaTime - PourTime;
        }
    }

    void SaveDrink()
    {
        float BeerGrade;

        BeerGrade = BeerLevel;

        Drinks.Add(BeerGrade);

        print(Drinks.Count);

        Instantiate(BeerPrefab, TrayLocation.transform.position, Quaternion.identity);
        BeerMug.transform.position = BeerPostions[current].transform.position;

        finishButton.SetActive(true);

    }

    public void Finish(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }
}
