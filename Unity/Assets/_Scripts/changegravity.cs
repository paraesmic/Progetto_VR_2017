using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changegravity : MonoBehaviour {
	private bool gravityup = false;
	private Vector3 gravità_giù = new Vector3 (0,-9,0);
	private Vector3 gravità_su = new Vector3 (0,9,0);
	//private Vector3 grav = Vector3.zero;
	private float degree;
	private float angle = 270;

	// Use this for initialization
	void Start () {
		
		
	}

	// Update is called once per frame
	void Update () {
//		
//
//		if (Input.GetMouseButtonDown (1) && gravityup == false) {
//			Physics.gravity = gravità_su;
//			gravityup = true;
//			//m_CharacterController.transform.Rotate (0, 0, 180);
//			//transform.Rotate (0, 0, 180*Time.deltaTime);
//			//ruota(0,0,180*Time.deltaTime);
//			degree=180;
//		} else if (Input.GetMouseButtonDown (1) && gravityup == true) {
//			//ruota(0,0,180*Time.deltaTime);
////			transform.Rotate (0, 0, 180*Time.deltaTime);
//			//m_CharacterController.transform.Rotate (0,0,180);
//			Physics.gravity = gravità_giù;
//			gravityup = false;
//			degree = 0;
//		}
//
//		transform.rotation = Quaternion.Lerp (transform.rotation, Quaternion.Euler(0,angle,degree), Time.deltaTime*4);
//
//		
	}

}
