using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : Button
{
    public static bool rotar = true;
    public static bool resetear = false;
    override public void onClickAction(){
        //If the camera is in the scenary
        if(!GameController.frente)Debug.Log("No frente");
        if (rotar == true){
            GameController.rotar();

        //If the camera is in a Big Furniture
        } else if(resetear){
            //Returns to the main camera
            Debug.Log("Desactivando");
            GameController.hideObject(); 
            GameController.rotar();
            Arrow.rotar = true;
        } else {
            Debug.Log("Vaya");
            //Hide the big Furniture
            GameController.hideObject(); 
            //Returns to the main camera
            Camera.main.transform.position = new Vector3(0, 7, -5);
            //Enable the rotation
            rotar = true;
        }
    }

    
}
