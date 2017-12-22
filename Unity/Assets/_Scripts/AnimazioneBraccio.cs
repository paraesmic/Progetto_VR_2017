using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimazioneBraccio : MonoBehaviour
{

    public bool BraccioSu = false;
    public Animator anim;
    //public Animation azione;

    public GameObject ajeje;

    // Use this for initialization
    void Start()
    {
       // anim.GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {

       // if (Input.GetKeyUp("1") == false)
       //     anim.SetBool("uno", false);

        if (Input.GetKeyDown("tab") )
        {
            BraccioSu = true;
            anim.Play("up");
       
            ajeje.GetComponent<ScriptSchermo>().IsOn = true;

        }

        if (Input.GetKeyUp("tab"))
        {
            BraccioSu = false;
           
            anim.SetBool("uno",true);
           
            ajeje.GetComponent<ScriptSchermo>().IsOn = false;
        }

        if (anim.GetCurrentAnimatorStateInfo(0).IsName("down"))
            anim.SetBool("uno", false);



    }
}

    

