using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimazioneBraccio : MonoBehaviour
{

    public bool BraccioSu = false;
    public Animator anim;
    //public Animation azione;

    public GameObject oggettoSchermo;

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

        if (Input.GetMouseButtonDown(1) )
        {
            BraccioSu = true;
            anim.Play("up");
       
            oggettoSchermo.GetComponent<ScriptSchermo>().IsOn = true;

        }

        if (Input.GetMouseButtonUp(1) )
        {
            BraccioSu = false;
           
            anim.SetBool("uno",true);
           
            oggettoSchermo.GetComponent<ScriptSchermo>().IsOn = false;
        }

        if (anim.GetCurrentAnimatorStateInfo(0).IsName("down"))
            anim.SetBool("uno", false);



    }
}

    

