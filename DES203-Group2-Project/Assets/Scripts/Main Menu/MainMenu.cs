using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void LoadScene()
    {
        SceneManager.LoadScene(1);
    }

    public void PlayGame()
    {
        StartCoroutine(_wait());
    }

    IEnumerator _wait()
    {
        yield return new WaitForSeconds(1);
        LoadScene();
    }

    public void QuitGame ()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
