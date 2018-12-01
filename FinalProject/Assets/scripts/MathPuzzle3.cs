using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MathPuzzle3 : MonoBehaviour
{

    public InputField input3;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            
            input3.Select();
        }

    }

    void checkInputField(string value)
    {

    }
}
