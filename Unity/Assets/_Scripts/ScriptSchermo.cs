using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptSchermo : MonoBehaviour {

    public bool IsOn;
    //servono a scalare lo schermo
    private int i = 0;
    private int j = 25;
    private bool start = true;

    public MeshRenderer currentRenderer;
    public Texture2D down;
    public Texture2D up;
    public Texture2D left;
    public Texture2D right;

    //public float posizioneY;
    //public float posizioneX;

    //public float x;
    //public float y;

    string[] vettore = new string[] {"down","left","up","right"};
    public int posizione=0;
    public string direzione;


    // Use this for initialization
    void Start () {
        IsOn = false;
        transform.localScale = new Vector3(0, 0, 0);
        //x= posizioneY = Input.mousePosition.y;
        //y = posizioneX = Input.mousePosition.x;
        

    }

    // Update is called once per frame
    void Update() {

       //posizioneY = Input.mousePosition.y;
       //posizioneX = Input.mousePosition.x;

        if (IsOn == true)
        {
            if (i < 25)
            {
                transform.localScale = new Vector3(i/250f, i/250f, i/175f);
                i++;
            }
            start = false;

             

            //if (posizioneX>900 & posizioneX<1000 & posizioneY<500)
            //    currentRenderer.material.SetTexture("_MainTex", down);
            //if (posizioneX > 900 & posizioneX < 1000 & posizioneY > 600)
            //    currentRenderer.material.SetTexture("_MainTex", up);
            //if (posizioneY > 500 & posizioneY < 600 & posizioneX < 900)
            //    currentRenderer.material.SetTexture("_MainTex", left);
            //if (posizioneY > 500 & posizioneY < 600 & posizioneX > 1000)
            //    currentRenderer.material.SetTexture("_MainTex", right);

            if (Input.GetAxis("Mouse ScrollWheel") > 0f)
            {
                if (posizione == 3) posizione = 0;
                else posizione++;
                direzione = vettore[posizione];
            }
            if (Input.GetAxis("Mouse ScrollWheel") < 0f)
            {
                if (posizione == 0) posizione = 3;
                else posizione--;
                direzione = vettore[posizione];
            }
            if (direzione == "down")
                currentRenderer.material.SetTexture("_MainTex", down);
            if (direzione == "up")
                currentRenderer.material.SetTexture("_MainTex", up);
            if (direzione == "left")
                currentRenderer.material.SetTexture("_MainTex", left);
            if (direzione == "right")
                currentRenderer.material.SetTexture("_MainTex", right);




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
