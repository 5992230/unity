using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projector : MonoBehaviour {

    // Use this for initialization

    public GameObject hoverProjector;
    public GameObject selectionProjector;


    GameObject testObj;

	void Start () {
        testObj = GameObject.FindGameObjectWithTag("Units");
        if(!testObj)
        {
            Debug.Log("Can't Find Units Object");
        }
        else
        {
            Debug.Log("Find Units Object");
        }
        GameObject newSelectionObject = Instantiate(selectionProjector, testObj.transform.position, hoverProjector.transform.rotation) as GameObject;
        var projector = newSelectionObject.GetComponentInChildren<Projector>();
        if(!projector)
        {
            print("Can't find projector");
        }
        else
        { 
            Vector3 size = testObj.GetComponent<Renderer>().bounds.size;
            float maxCircle = Mathf.Max(size.x, size.y);
            projector.orthographicSize = maxCircle;
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
