using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravitySwitch : MonoBehaviour {

//    public bool button_State;
//    private Collider coll;
	public Vector3 nuova_gravità;


    // Use this for initialization
    void Start () {
//        button_State = false;
//        coll = GetComponent<Collider>();
    }
	
	// Update is called once per frame
	void Update () {
        
      
	}

    private void OnTriggerEnter(Collider coll)
    {
//        if (button_State == false)
//        {
//            button_State = true;
            Debug.Log("Funziona e diventa true!");
		Physics.gravity = nuova_gravità;
//        }
//        else
//        {
//            button_State = false;
//            Debug.Log("Funziona e diventa false!");
//        
//			Physics.gravity = new Vector3 (0, -9.8F,0);
//        }

    }

}
