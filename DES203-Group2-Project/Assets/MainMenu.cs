using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //TODO add PlayGame() to transition to first scene


    public void QuitGame ()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
