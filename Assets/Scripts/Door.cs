using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door: Furniture
{
    public static int passCounter;
    public static bool door_lock;
    public static AudioSource[] sounds;
    void Awake()
    {
        passCounter = 0;
        door_lock = true;
        sounds = GetComponents<AudioSource>();
    }

    override public void onClickAction(){
        if (door_lock) {
            sounds[0].Play();
        }   
        else {
          sounds[2].Play();
          SceneManager.LoadScene("End");  
        }
    }

    public static void updatePass(int value){
        passCounter += value;
        if(passCounter == 3){
            sounds[0].Play();
            door_lock = false;
            //play song
        } else if (!door_lock) {
            sounds[1].Play();
            door_lock=true;
            }
    }
}