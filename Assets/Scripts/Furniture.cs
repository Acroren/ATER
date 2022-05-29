using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Furniture : MonoBehaviour, IClicked
{
    private Renderer render;
    //Asignar el material llamado Voxel

    virtual public void onClickAction(){
        Debug.Log("Clicked");
    }

    public void enterZone(){
        render = GetComponent<Renderer>();
        render.material.color=Color.black;
    }

    public void exitZone(){
        render = GetComponent<Renderer>();
        render.material.color= Color.white;
    }
}