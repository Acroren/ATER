using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChairScript: MonoBehaviour, IClicked
{
    public void onClickAction(){
        Destroy(gameObject);
    }
    public void onZone(){
        Debug.Log("Encima de la Chair");
    }
}