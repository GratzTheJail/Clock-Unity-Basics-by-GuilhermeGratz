using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlInputs : MonoBehaviour
{
    private bool boolPlaceholder = true;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            GameObject.Find("Clock").GetComponent<Clock>().constantFlow = boolPlaceholder;
            boolPlaceholder = !boolPlaceholder;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Quit Application");
            Application.Quit();
        }
    }
}
