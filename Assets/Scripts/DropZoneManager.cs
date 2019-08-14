using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropZoneManager : MonoBehaviour {

    public GameObject ExploreZone;
    public GameObject InventoryZone;

	// Use this for initialization
	void Start () {
        ExploreZone = GameObject.FindGameObjectWithTag("Dropzone");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
