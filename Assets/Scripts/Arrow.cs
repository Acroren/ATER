using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour, IClicked
{
    private Renderer render;
    private Color colorOriginal;
    public float transparencia = 0.3f;
    //Asignar el material llamado Voxel

    private void Awake() {
        render = GetComponent<Renderer>();
        colorOriginal = render.material.color;
        render.material.color = new Color(colorOriginal.r, colorOriginal.g, colorOriginal.b, transparencia);
    }

    virtual public void onClickAction(){
        Debug.Log("Clicked");
    }

    public void enterZone(){
        render = GetComponent<Renderer>();
        //cambiar opacidad del material a 0.5
        render.material.color = new Color(colorOriginal.r, colorOriginal.g, colorOriginal.b, 0f);
        //render.material.=Color.black;
    }

    public void exitZone(){
        render = GetComponent<Renderer>();
        render.material.color= new Color(colorOriginal.r, colorOriginal.g, colorOriginal.b, transparencia);;
    }
}

