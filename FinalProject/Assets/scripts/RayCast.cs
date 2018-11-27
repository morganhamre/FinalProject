using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCast : MonoBehaviour {

    public GameObject item;
    public float rayDistance = 20F;
    public LayerMask layerMask;
	
	// Update is called once per frame
	void Update () {
        item = checkHit();
        if(item != null){
            Light itemLight = item.GetComponent<Light>();
            itemLight.enabled = true;
            TextMesh text = item.GetComponentInChildren<TextMesh>();
            text.GetComponent<MeshRenderer>().enabled = true;
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
