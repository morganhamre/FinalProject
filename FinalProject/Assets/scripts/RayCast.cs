using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCast : MonoBehaviour {

    public GameObject item;
    public GameObject door1;
    public float rayDistance = 20F;
    public LayerMask layerMask;
    public Dictionary<GameObject, int> found = new Dictionary<GameObject, int>(); //keep track of items found
	
	// Update is called once per frame
	void Update () {
        item = checkHit();
        if(item != null){
            Light itemLight = item.GetComponent<Light>();
            itemLight.enabled = true;
            TextMesh[] text = item.GetComponentsInChildren<TextMesh>();
            text[0].GetComponent<MeshRenderer>().enabled = true;
            text[1].GetComponent<MeshRenderer>().enabled = true;

            if(!found.ContainsKey(item)){
                found.Add(item, 1);
            }
        }

        if(found.Count == 4){
            Object.Destroy(door1);
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
