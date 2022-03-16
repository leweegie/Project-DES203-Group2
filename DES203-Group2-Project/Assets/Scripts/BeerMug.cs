using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BeerMug : MonoBehaviour
{
    public GameObject BeerMugIMG;
    public GameObject BeerMugLocation;
    public GameObject[] BeerPostion;
    public GameObject TrayLocation;
    public GameObject PourBeer1, PourBeer2, PourBeer3;
    public GameObject BeerPrefab;
    int current = 0;
    // remove Public
   public float PourTime;
    float GameTime;
    float BeerLevel;
    bool KeyPressed = false;
    ArrayList Drinks = new ArrayList();
    public GameObject finishButton;

    // Start is called before the first frame update
    public void Start()
    {
        // set beer mugs location to location one
        BeerMugLocation.transform.position = BeerPostion[current].transform.position;

        GameTime -= Time.time;

        BeerMugIMG.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            BeerMugIMG.SetActive(true);
            Debug.Log("letThereBeBeer");
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            current--;
            BeerMugLocation.transform.position = BeerPostion[current].transform.position;
            Debug.Log("Leftmovement");
            PourTime = 0f;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            current++;
            BeerMugLocation.transform.position = BeerPostion[current].transform.position;
            Debug.Log("Rightmovement");
            PourTime = 0f;
        }
        
        if (Input.GetKey(KeyCode.A))
        {
            PourBeer1.SetActive(true);
            KeyPressed = true;
            Timer();
        }
        else
        {
            PourBeer1.SetActive(false);
        }

        if (Input.GetKey(KeyCode.S))
        {
            PourBeer2.SetActive(true);
            KeyPressed = true;
            Timer();
        }
        else
        {
            PourBeer2.SetActive(false);
        }

        if (Input.GetKey(KeyCode.D))
        {
            PourBeer3.SetActive(true);
            KeyPressed = true;
            Timer();
        }
        else
        {
            PourBeer3.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            BeerLevel = PourTime;
            
            BeerMugLocation.transform.position = TrayLocation.transform.position;

            if (BeerLevel <= 4)
            {
                //Poor Pour
                Debug.Log("poorPour");
            }
            else if (BeerLevel >= 4.1 || BeerLevel <=8)
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
            BeerMugIMG.SetActive(false);
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
        BeerMugLocation.transform.position = BeerPostion[current].transform.position;

        finishButton.SetActive(true);

    }

    public void Finish(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }
}
    