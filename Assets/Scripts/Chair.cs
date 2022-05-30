using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chair: Furniture
{

    override public void onClickAction(){
        //si es grande
        if (isBig == true){
            //cambiar posicion de la camara
            Key.activateKey();
        }
        else{
            //cambiar posicion de la camara
            Arrow.rotar = false;
            mainCamera.transform.position = objectCameraPosition;
        }
        Debug.Log("Clicked");
        
    }


}