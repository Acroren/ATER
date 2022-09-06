using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lock : Furniture
{
    override public void onClickAction(){
    GameController.showObject("LockBig");
    //Change the position of the camera
    Arrow.rotar = false;
    mainCamera.transform.position = objectCameraPosition;
        
    }
}
