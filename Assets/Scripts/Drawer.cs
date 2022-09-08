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

        if (!DrawerOpenned){
            if(Key.llave == true){
                DrawerOpenned = true;
                sounds[0].Play();
                sign.SetActive(true);
                StartCoroutine(wait());

                Key.activateNote();
                Hint2.activateNote();
            }
            else{
                sounds[1].Play();
            }
            
        }
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


