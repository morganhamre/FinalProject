using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MathPuzzle2 : MonoBehaviour
{

    public InputField input2;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            
            input2.Select();
        }

    }

    void checkInputField(string value)
    {

    }
}
