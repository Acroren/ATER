using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SymbolBox : Furniture
{
    public int value = -1;
    private bool SymbolPressed = false;
    public Material originalMaterial;
    public Material preseedMaterial;
    private AudioSource source;
    void Awake()
    {
        source = GetComponent<AudioSource>();
    }

    override public void onClickAction(){
      //  if(SafeController.open){
            //si el symbolo no está presionado
            source.Play();
            if (!SymbolPressed){
                SymbolPressed = true;
                
                transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z+0.5f);
                render.material=preseedMaterial;
                Door.updatePass(value);
            }else{
                SymbolPressed = false;
                transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z-0.5f);
                render.material=originalMaterial;
                Door.updatePass(-value);
            }    
      //  }
        
    }
    override public void enterZone(){
        render.material.color=Color.black;
    }

    override public void exitZone(){
        render.material.color= Color.white;
    }
}


