using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BehindBar : MonoBehaviour
{

    // Update is called once per frame
    public void MoveToBar()
    {
        SceneManager.LoadScene(2);
    }
}
