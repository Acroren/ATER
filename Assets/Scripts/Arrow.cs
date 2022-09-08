using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : Button
{
    public static bool rotar = true;
    public static bool resetear = false;
    override public void onClickAction(){
        if (rotar == true){
            GameController.rotar();
        //If the camera is in a Big Furniture
        } else if(resetear){
            //Returns to the main camera
            GameController.hideObject(); 
            GameController.rotar();
            rotar = true;
            resetear = false;
        } else {
            //Hide the big Furniture
            GameController.hideObject(); 
            //Returns to the main camera
            Camera.main.transform.position = new Vector3(0, 7, -5);
            //Enable the rotation
            rotar = true;
        }
    }

    
}

