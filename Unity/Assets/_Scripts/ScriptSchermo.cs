using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptSchermo : MonoBehaviour {

    public bool IsOn;
    private int i = 0;
    private int j = 25;
    private bool start = true;

    public MeshRenderer currentRenderer;
    public Texture2D down;
    public Texture2D up;
    public Texture2D left;
    public Texture2D right;

    

    // Use this for initialization
    void Start () {
        IsOn = false;
        transform.localScale = new Vector3(0, 0, 0);
	}

    // Update is called once per frame
    void Update() {

        if (IsOn == true)
        {
            if (i < 25)
            {
                transform.localScale = new Vector3(i/250f, i/250f, i/175f);
                i++;
            }
            start = false;

            if (Input.GetKeyDown("down") == true)
                currentRenderer.material.SetTexture("_MainTex", down);
          //  if (Input.GetKeyDown("up") == true)
           //     currentRenderer.material.SetTexture("_MainTex", up);
            if (Input.GetKeyDown("left") == true)
                currentRenderer.material.SetTexture("_MainTex", left);
            if (Input.GetKeyDown("right") == true)
                currentRenderer.material.SetTexture("_MainTex", right); 
            
           
            if (Input.mousePosition.x>640 && Input.mousePosition.y<360 )
                currentRenderer.material.SetTexture("_MainTex", up);
        }

      
        if (IsOn == false && start==false)
        {
            if (i >= 0)
            {             
                transform.localScale = new Vector3( ((2*j-i) / 250f) , ((2*j- i) / 250f), ((2*j- i) / 175f));
                i--;
            }          
        }
        j = i;


    }
}
