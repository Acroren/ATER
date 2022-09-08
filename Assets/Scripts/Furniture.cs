using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Furniture : MonoBehaviour, IClicked
{
    //Variables
    public Renderer render;
    public Camera mainCamera;
    public Vector3 mainCameraPosition;
    public bool isBig = false;
    public  Vector3 objectCameraPosition = new Vector3(64, 10, 0);

    //Set variable values
    private void Start() {
        render = GetComponent<Renderer>();
        mainCamera = Camera.main;
        mainCameraPosition = mainCamera.transform.position;
    }

    //When is clicked, move the camera.
    virtual public void onClickAction(){
        Arrow.rotar = false;
        mainCamera.transform.position = objectCameraPosition;
    }

    //When is the mouse is over , recolor the object.
    virtual public void enterZone(){
        render.material.color=Color.black;
    }

    //When is the mouse exit, returns the original color.
    virtual public void exitZone(){
        render.material.color= Color.white;
    }
}

