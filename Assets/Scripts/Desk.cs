using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desk: Furniture
{
    override public void onClickAction(){
        GameController.showObject("DeskBig");
        Arrow.rotar = false;
        mainCamera.transform.position = objectCameraPosition;
    }
}
