using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drawer: Furniture
{
    private bool DrawerOpenned = false;
    public Color originalColor;
    override public void onClickAction(){
        //si es grande
        if (!DrawerOpenned){
            
            //Key.activateKey();
            if(Key.llave == true){
                DrawerOpenned = true;
                //GameController.showObject("Drawer");
                Key.activateNote();
                Hint2.activateNote();
                Debug.Log("El cajón se ha abierto");
            }
            else{
                Debug.Log("Está cerrado");
            }
            
        }
        else {
            Debug.Log("El cajón está abierto");
        }
        
    }
    override public void enterZone(){
        render.material.color=Color.black;
    }

    override public void exitZone(){
        render.material.color= originalColor;
    }
}


