using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desk: Furniture
{
    private bool DrawerOpenned = false;
    override public void onClickAction(){
        //si es grande
        if (isBig && !DrawerOpenned){
            
            //Key.activateKey();
            if(Key.llave == true){
                DrawerOpenned = true;
                //GameController.showObject("Drawer");
                Debug.Log("El cajón se ha abierto");
            }
            else{
                Debug.Log("Está cerrado");
            }
            
        }
        else if (!isBig){
            //Activate big object
            GameController.showObject("DeskBig");
            //Change the position of the camera
            Arrow.rotar = false;
            mainCamera.transform.position = objectCameraPosition;
        }
        else {
            Debug.Log("Nada que hacer");
        }
        
    }


}
