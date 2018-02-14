using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pulsante : MonoBehaviour {

    public GameObject porta;
    public bool button_State;
    private Collider coll;

    // Use this for initialization
    void Start () {
        button_State = false;
        coll = GetComponent<Collider>();
    }
	
	// Update is called once per frame
	void Update () {

        if (button_State==true)
            porta.transform.position = new Vector3(-5, 4, 6);
        else
            porta.transform.position = new Vector3(-5, 4, 3);
    }

    private void OnTriggerStay(Collider coll)
    {
        button_State = true;
          
    }
}
