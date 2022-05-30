using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : Button
{
    public static bool rotar = true;

    override public void onClickAction(){
        if (rotar == true){
            GameController.rotar();
        } else {
            rotar = true;
            Camera.main.transform.position = new Vector3(0, 7, -5);
        }
    }

    
}
