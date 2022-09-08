using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoidFurniture: Furniture
{

    public string target;
    override public void onClickAction(){
        //si no es grande
        if (!isBig){
            //Activate big object
            GameController.showObject(target);
            //Change the position of the camera
            Arrow.rotar = false;
            if(!GameController.frente){
                GameController.rotar();
                Arrow.resetear = true;
            }
            mainCamera.transform.position = objectCameraPosition;
        }
    }


}