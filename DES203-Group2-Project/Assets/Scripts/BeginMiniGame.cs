using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BeginMiniGame : MonoBehaviour
{
    public void Wait()
    {
        StartCoroutine(_wait());
        //SceneManager.LoadScene(3);
    }
    void LoadMiniGame()
    {
        SceneManager.LoadScene(3);
    }

    IEnumerator _wait()
    {
        yield return new WaitForSeconds(3);
        LoadMiniGame();
    }

}
