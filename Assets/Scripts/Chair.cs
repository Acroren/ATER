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
        if (isBig && !keyActivated){
            sign.SetActive(true);
            StartCoroutine(wait());
            source.Play();

            keyModel.SetActive(false);
            Key.activateKey();
            keyActivated = true;
        }
        else if (!isBig){
            GameController.showObject("ChairBig");
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