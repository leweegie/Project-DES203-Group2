using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random = System.Random;

public class BeginMiniGame : MonoBehaviour
{
    public void WaitMiniGame()
    {
        StartCoroutine(_wait());

    }

    void LoadMiniGame()
    {
        Random r = new Random();
        int rInt = r.Next(0, 2);
        rInt += 3;
        SceneManager.LoadScene(rInt);
    }

    IEnumerator _wait()
    {
        yield return new WaitForSeconds(3);
        LoadMiniGame();
    }

}
