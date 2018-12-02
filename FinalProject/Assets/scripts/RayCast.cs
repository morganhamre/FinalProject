using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCast : MonoBehaviour {

    public GameObject item;
    public GameObject door1;
    public float rayDistance = 20F;
    public LayerMask layerMask;
    public Dictionary<GameObject, int> englishFound = new Dictionary<GameObject, int>(); //keep track of items found
    public Dictionary<GameObject, int> scienceFound = new Dictionary<GameObject, int>(); //keep track of items found


	// Update is called once per frame
	void Update () {
        item = checkHit();
        if(item != null){
            Light itemLight = item.GetComponent<Light>();
            itemLight.enabled = true;
            if(item.tag == "english"){
                TextMesh[] text = item.GetComponentsInChildren<TextMesh>();
                //enable found text
                text[0].GetComponent<MeshRenderer>().enabled = true;
                //enable word on poem
                text[1].GetComponent<MeshRenderer>().enabled = true;

                if (!englishFound.ContainsKey(item))
                {
                    englishFound.Add(item, 1);
                }

            } else if(item.tag == "science"){
                TextMesh[] text = item.GetComponentsInChildren<TextMesh>();
                //enable found text
                text[0].GetComponent<MeshRenderer>().enabled = true;
                //disable word on list
                text[1].GetComponent<MeshRenderer>().enabled = false;

                if (!scienceFound.ContainsKey(item))
                {
                    scienceFound.Add(item, 1);
                }
            }



        }

        if(englishFound.Count == 4){
            Object.Destroy(door1);
        }

        if(scienceFound.Count == 5){
            MainMenu.LoadScene("Win");
        }
	}

    GameObject checkHit(){
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.forward, out hit, rayDistance, layerMask))
        {
            return hit.collider.gameObject;
        }
        else{
            return null;
        } 
    }

}
