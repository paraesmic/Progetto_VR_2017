using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour {

//    public bool button_State;
//    private Collider coll;



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
		Physics.gravity = new Vector3 (0, -9.8F, 9.8F);
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
