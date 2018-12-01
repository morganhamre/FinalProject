using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleCheck : MonoBehaviour {


    public static int puzzlesSolved = 0;
    public GameObject door2;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(puzzlesSolved == 3){
            Object.Destroy(door2);
        }
	}

    public static void numPuzzlesSolved(){
        puzzlesSolved++;
    }
}
