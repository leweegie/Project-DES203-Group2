using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BeginMiniGame : MonoBehaviour
{

    public void Wait()
    {
        SceneManager.LoadScene(3);
    }

    IEnumerator _wait()
    {
        yield return new WaitForSeconds(4);
        SceneManager.LoadScene(3);
    }

}
