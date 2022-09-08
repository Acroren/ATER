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
}


