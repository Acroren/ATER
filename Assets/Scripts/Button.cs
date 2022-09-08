using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour, IClicked
{
    private Renderer render;
    private Color colorOriginal;
    public static bool actited = true;
    public float transparencia = 0.3f;
    //Asignar el material llamado Voxel

    private void Awake() {
        render = GetComponent<Renderer>();
        colorOriginal = render.material.color;
        render.material.color = new Color(colorOriginal.r, colorOriginal.g, colorOriginal.b, transparencia);
    }

    virtual public void onClickAction(){
        
    }

    virtual public void enterZone(){
        if (actited == true){
            render = GetComponent<Renderer>();
            render.material.color = new Color(colorOriginal.r, colorOriginal.g, colorOriginal.b, 0f);
        }
    }

    virtual public void exitZone(){
        if (actited == true){
            render = GetComponent<Renderer>();
            render.material.color= new Color(colorOriginal.r, colorOriginal.g, colorOriginal.b, transparencia);;
        }

    }
}

