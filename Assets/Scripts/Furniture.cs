using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Furniture : MonoBehaviour, IClicked
{
    public Renderer render;
    public Camera mainCamera;
    public Vector3 mainCameraPosition;
    public bool isBig = false;
    //private Vector3 mainCameraPosition = new Vector3(0, 7, -5);
    public  Vector3 objectCameraPosition = new Vector3(64, 10, 0);

    private void Start() {
        render = GetComponent<Renderer>();
        mainCamera = Camera.main;
        mainCameraPosition = mainCamera.transform.position;
    }

    virtual public void onClickAction(){
        Debug.Log("Clicked");
        Arrow.rotar = false;
        //cambiar posicion de la camara
        mainCamera.transform.position = objectCameraPosition;
    }

    virtual public void enterZone(){
        render.material.color=Color.black;
    }

    virtual public void exitZone(){
        render.material.color= Color.white;
    }
}