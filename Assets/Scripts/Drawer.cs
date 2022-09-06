using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drawer: Furniture
{
    private bool DrawerOpenned = false;
    public Color originalColor;
    public GameObject sign;
    public AudioSource[] sounds;
    void Awake()
    {
        sounds = GetComponents<AudioSource>();
    }
    override public void onClickAction(){
        //si es grande
        if (!DrawerOpenned){
            
            //Key.activateKey();
            if(Key.llave == true){
                DrawerOpenned = true;
                sounds[0].Play();
                sign.SetActive(true);
                StartCoroutine(wait());
                //GameController.showObject("Drawer");
                Key.activateNote();
                Hint2.activateNote();
                Debug.Log("El cajón se ha abierto");
            }
            else{
                sounds[1].Play();
                Debug.Log("Está cerrado");
            }
            
        }
        else {
            Debug.Log("El cajón está abierto");
        }
        
    }
    override public void enterZone(){
        render.material.color=Color.black;
    }

    override public void exitZone(){
        render.material.color= originalColor;
    }
    IEnumerator wait()  //  <-  its a standalone method
    {
        yield return new WaitForSeconds(1);
        sign.SetActive(false);
    }

}


