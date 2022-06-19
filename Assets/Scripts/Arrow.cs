using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : Button
{
    public static bool rotar = true;

    override public void onClickAction(){
        //If the camera is in the scenary
        if (rotar == true){
            GameController.rotar();

        //If the camera is in a Big Furniture
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
