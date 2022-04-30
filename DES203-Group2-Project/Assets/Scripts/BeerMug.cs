using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BeerMug : MonoBehaviour
{
    public GameObject BeerMugIMG;
    public GameObject BeerMugLocation;
    public GameObject[] TapPosition;
    public GameObject[] TrayLocation;
    public GameObject PourBeer1, PourBeer2, PourBeer3;
    public GameObject BeerPrefab;
    int current = 0;
    int drinksFinished = 0;
    float startTime;
    float PourTime;
    float GameTime;
    float BeerLevel;
    bool KeyPressed = false;
    ArrayList Drinks = new ArrayList();
    public GameObject finishButton;
    public AudioSource Serve;
    public AudioSource Pour;

    // Start is called before the first frame update
    public void Start()
    {
        // set beer mugs location to location one
        BeerMugLocation.transform.position = TapPosition[current].transform.position;

        GameTime -= Time.time;

        BeerMugIMG.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        //begin mini game/get new tankard
        {
            Serve.Play();
            current = 0;
            BeerMugLocation.transform.position = TapPosition[current].transform.position;
            BeerMugIMG.SetActive(true);
            BeerMugIMG.GetComponent<Animator>().enabled = true;
            BeerMugIMG.GetComponent<Animator>().Play("Beer_Idle");
            Debug.Log("letThereBeBeer");
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            //move beer to tap location -1 from current position
            if (current > 0)
            {
                Serve.Play();
                current--;
                BeerMugLocation.transform.position = TapPosition[current].transform.position;
                Debug.Log("Leftmovement");
            }
            PourTime = 0f;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            //move beer to tap location +1 from current position
            if (current < TapPosition.Length)
            {
                Serve.Play();
                current++;
                BeerMugLocation.transform.position = TapPosition[current].transform.position;
                Debug.Log("Rightmovement");
            }
            PourTime = 0f;
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            //move beer to tap location on top layer if its currently on bottom layer
            if (current == 0 || current == 1)
            {
                Serve.Play();
                current = 3;
                BeerMugLocation.transform.position = TapPosition[current].transform.position;
            }
            else if (current == 2)
            {
                Serve.Play();
                current = 4;
                BeerMugLocation.transform.position = TapPosition[current].transform.position;
            }
            PourTime = 0f;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            //move beer to tap location on bottom layer if its currently on top layer
            if (current > 2)
            {
                Serve.Play();
                current = 1;
                BeerMugLocation.transform.position = TapPosition[current].transform.position;
            }
            PourTime = 0f;
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            Pour.Play();
            startTime = Time.deltaTime;
            BeerMugIMG.GetComponent<Animator>().enabled = true;
        }

        if (Input.GetKey(KeyCode.E))
        {
            
            PourTime = Time.deltaTime - startTime;
            BeerMugIMG.GetComponent<Animator>().Play("Pour_Beer");
        }

        if (Input.GetKeyUp(KeyCode.E))
        {
            Pour.Stop();
            BeerMugIMG.GetComponent<Animator>().enabled = false;
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            Serve.Play();
            BeerLevel = PourTime;
            BeerMugLocation.transform.position = TrayLocation[drinksFinished].transform.position;
            if (BeerLevel <= 4)
            {
                //Poor Pour
                Debug.Log("poorPour");
            }
            else if (BeerLevel > 4 || BeerLevel <= 8)
            {
                // average pour
                Debug.Log("AvragePour");
            }
            else if (BeerLevel > 8)
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

    void Timer(float PourTime)
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

        Instantiate(BeerPrefab, TrayLocation[drinksFinished].transform.position, Quaternion.identity);
        BeerMugIMG.SetActive(false);
        //BeerMugLocation.transform.position = TapPosition[current].transform.position;
        drinksFinished++;
        finishButton.SetActive(true);

    }

    IEnumerator _wait()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(2);
    }

    public void Finish()
    {
        StartCoroutine(_wait());
    }
}
