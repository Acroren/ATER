using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chair: Furniture
{

    private bool keyActivated = false;
    public GameObject keyModel, sign;
    private AudioSource source;
    void Awake()
    {
        source = GetComponent<AudioSource>();
    }
    override public void onClickAction(){
        //si es grande
        if (isBig && !keyActivated){
            Variables.door_lock=false;
            sign.SetActive(true);
            StartCoroutine(wait());
            source.Play();

            keyModel.SetActive(false);
            Key.activateKey();
            keyActivated = true;
        }
        else if (!isBig){
            //Activate big object
            GameController.showObject("ChairBig");
            //Change the position of the camera
            Arrow.rotar = false;
            mainCamera.transform.position = objectCameraPosition;
        }
        else {
            sign.SetActive(false);
        }
        
    }
    IEnumerator wait()  //  <-  its a standalone method
    {
        yield return new WaitForSeconds(1);
        sign.SetActive(false);
    }
}