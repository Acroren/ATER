using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Furniture : MonoBehaviour, IClicked
{
    private Renderer render;
    private Camera mainCamera;
    private Vector3 mainCameraPosition;
    public  Vector3 objectCameraPosition = new Vector3(0, 0, 0);

    private void Start() {
        render = GetComponent<Renderer>();
        mainCamera = Camera.main;
        mainCameraPosition = mainCamera.transform.position;
    }

    virtual public void onClickAction(){
        Debug.Log("Clicked");
        //cambiar posicion de la camara
        mainCamera.transform.position = objectCameraPosition;
    }

    public void enterZone(){
        render.material.color=Color.black;
    }

    public void exitZone(){
        render.material.color= Color.white;
    }
}