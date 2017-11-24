using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {
	public float sensitivity=5.0f;
	public float smoothing = 2.0f;
	public bool atterrato;
	Vector2 rot;
	Vector2 smoothV;

	GameObject controller;
	public string contr;

	// Use this for initialization
	void Start () {
		controller = this.transform.parent.gameObject;
		contr = controller.tag;

	}
	
	// Update is called once per frame
	void Update () {

		
	}
}
