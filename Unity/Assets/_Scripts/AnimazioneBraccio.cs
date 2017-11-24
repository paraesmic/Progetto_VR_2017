using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimazioneBraccio : MonoBehaviour
{

    public bool BraccioSu = false;
    // public float frame = 0;
    public Animator anim;
    public Animation azione;

    public GameObject ajeje;  // per cambiare la variabile dello schermo -> renderlo invisibile quando non serve

    // Use this for initialization
    void Start()
    {
        anim.GetComponent<Animator>();
        azione.GetComponent<Animation>();

        ajeje = GameObject.Find("Schermo");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            BraccioSu = true;
            anim.Play("up");
            //if (anim.GetCurrentAnimatorStateInfo(0).normalizedTime > 1 && !Animator.IsInTransition(0))
            //    anim.Play("loop");

            ajeje.GetComponent<ScriptSchermo>().IsOn = true;

        }

        if (Input.GetKeyUp("1"))
        {
            BraccioSu = false;
            //anim.Play("down");
            anim.SetTrigger("uno");
        }

        if (azione.IsPlaying("loop"))
        {
            ajeje.GetComponent<ScriptSchermo>().IsOn = true;
        }


    }
}

    

