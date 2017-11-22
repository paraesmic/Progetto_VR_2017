using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimazioneBraccio : MonoBehaviour {

    public bool ok = false;
    public float frame = 0;
    public Animator anim;

	// Use this for initialization
	void Start () {
        anim.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if( Input.GetKeyDown("1") )
        {
            ok = true;
            anim.Play("up");
           // frame = AnimationState.normalizedTime;

        //         if (animation["Aim"].normalizedTime >= .9)
        //        animation.Play("Shoot");
        }

        if (Input.GetKeyUp("1"))
        {
            ok = false;
            anim.Play("down");
        }

    }
}
