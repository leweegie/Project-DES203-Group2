using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prefab : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // get the script
        DragAndDrop Script = FindObjectOfType<DragAndDrop>();
        // run section of script
        Script.SetCanvas();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
