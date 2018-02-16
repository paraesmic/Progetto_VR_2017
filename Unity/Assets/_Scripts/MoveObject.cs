using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour {
    public GameObject item;
    public GameObject tempParent;
    public GameObject guide;
    //private float dist;
    bool vicinanza = false;

    // Use this for initialization
    void Start () {
        item.GetComponent<Rigidbody>().useGravity = true;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

 /*   private void OnTriggerEnter(Collider other)
    {   if (other.tag == "controller")
        vicinanza = true; 
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "controller")
            vicinanza = false;
    }
*/    void OnMouseDown()
    {
        float dist = Vector3.Distance(item.transform.position, guide.transform.position);
        Debug.Log(dist);
        if (Vector3.Distance(item.transform.position, guide.transform.position)<2f)
        {
            vicinanza = true;
            item.GetComponent<Rigidbody>().useGravity = false;
            item.GetComponent<Rigidbody>().isKinematic = true;
            item.transform.position = guide.transform.position;
            item.transform.rotation = guide.transform.rotation;
            item.transform.parent = tempParent.transform;
        }
    
    }
    void OnMouseUp()
    {
        if (vicinanza == true)
        {
            item.GetComponent<Rigidbody>().useGravity = true;
            item.GetComponent<Rigidbody>().isKinematic = false;
            item.transform.parent = null;
            item.transform.position = guide.transform.position;
            vicinanza = false;
        }
    }
}
