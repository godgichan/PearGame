﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnSound : MonoBehaviour
{
    public AudioSource myFx;
    public AudioClip hoverFX;
    public AudioClip clickFX;


    public void HoverSound()
    {
        myFx.PlayOneShot(hoverFX);
    }
    public void ClickSound()
    {
        myFx.PlayOneShot(clickFX);
       
    }
    // Start is called before the first frame update
    void Start()
    {

    }
   

}
