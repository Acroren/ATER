using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box: Furniture
{
    private bool BoxOpenned = false;
    public Color originalColor;
    public GameObject sign;
    public static AudioSource[] sounds;
    void Awake()
    {
        sounds = GetComponents<AudioSource>();
    }

    override public void onClickAction(){
        if(SafeController.open==true){
            if (!BoxOpenned){
                sounds[1].Play();
                BoxOpenned = true;
                sign.SetActive(true);
                StartCoroutine(wait());
                Hint3.activateNote();
                
            }
        } else {
            sounds[0].Play();
        }
    }

    IEnumerator wait()  //  <-  its a standalone method
    {
        yield return new WaitForSeconds(1);
        sign.SetActive(false);
    }
}


