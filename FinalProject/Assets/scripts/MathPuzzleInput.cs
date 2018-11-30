using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MathPuzzleInput : MonoBehaviour {

    public string solution = "14";
    InputField inputField;

	// Use this for initialization
	void Start () {
        inputField = GetComponent<InputField>();
	}
	
	// Update is called once per frame
    public void ValueChangeCheck () {
        if(inputField.text == solution){
            inputField.interactable = false;
            PuzzleCheck.numPuzzlesSolved();
        }
	}
}
