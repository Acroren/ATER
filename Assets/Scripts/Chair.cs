using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chair: Furniture
{

private bool keyActivated = false;
    override public void onClickAction(){
        //si es grande
        if (isBig && !keyActivated){
            
            Key.activateKey();
            keyActivated = true;
        }
        else if (!isBig){
            //cambiar posicion de la camara
            Arrow.rotar = false;
            mainCamera.transform.position = objectCameraPosition;
        }
        else {
            Debug.Log("Nada que hacer");
        }
        Debug.Log("Clicked");
        
    }


}