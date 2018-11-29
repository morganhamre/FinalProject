using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCast : MonoBehaviour {

    public GameObject item;
    public GameObject door;
    public float rayDistance = 20F;
    public LayerMask layerMask;
    public int numObjects = 0; //keeps track of the number of objects found
	
	// Update is called once per frame
	void Update () {
        item = checkHit();
        if(item != null){
            Light itemLight = item.GetComponent<Light>();
            itemLight.enabled = true;
            TextMesh[] text = item.GetComponentsInChildren<TextMesh>();
            text[0].GetComponent<MeshRenderer>().enabled = true;
            text[1].GetComponent<MeshRenderer>().enabled = true;
            numObjects++;
        }
        if(numObjects == 4){
            DestroyObject(door);
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
