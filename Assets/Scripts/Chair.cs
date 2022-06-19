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
            //Activate big object
            GameController.showObject("ChairBig");
            //Change the position of the camera
            Arrow.rotar = false;
            mainCamera.transform.position = objectCameraPosition;
        }
        else {
            Debug.Log("Nada que hacer");
        }
        
    }


}