using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PasswordKey : Furniture
{
    public int value = 0;
    public Material originalMaterial;
    public Material preseedMaterial;
    private AudioSource source;
    void Awake()
    {
        source = GetComponent<AudioSource>();
    }

    override public void onClickAction(){
        //si el symbolo no está presionado
        source.Play(); 
        SafeController.press(value);
    }
    override public void enterZone(){
        render.material.color=Color.black;
    }

    override public void exitZone(){
        render.material.color= Color.white;
    }
}


