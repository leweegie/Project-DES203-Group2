using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BeginMiniGame : MonoBehaviour
{
    public void WaitMiniGame()
    {
        StartCoroutine(_wait());

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
