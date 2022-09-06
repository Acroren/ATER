using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box: Furniture
{
    private bool BoxOpenned = false;
    public Color originalColor;
    public static AudioSource[] sounds;
    void Awake()
    {
        sounds = GetComponents<AudioSource>();
    }


    override public void onClickAction(){
        if(SafeController.open==true){
            if (!BoxOpenned){
                sounds[1].Play();
                BoxOpenned = true;
                //GameController.showObject("Drawer");
                Hint3.activateNote();
                Debug.Log("Taratatata");
            }
            else {
                Debug.Log("Está abierto");
            }
        } else {
            sounds[0].Play();
            Debug.Log("Está cerrado");
        }
        
        
    }
    override public void enterZone(){
        render.material.color=Color.black;
    }

    override public void exitZone(){
        render.material.color= originalColor;
    }
}


