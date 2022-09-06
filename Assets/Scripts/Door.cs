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
            Debug.Log("Locked"); 
        }   
        else {
          sounds[2].Play();
          Debug.Log("Cambiando escena"); 
          SceneManager.LoadScene("End");  
        }
    }

    public static void updatePass(int value){
        passCounter += value;
        Debug.Log("Valor" + passCounter);
        if(passCounter == 3){
            sounds[0].Play();
            Debug.Log("Puerta abierta");
            door_lock = false;
            //play song
        } else if (!door_lock) {
            sounds[1].Play();
            Debug.Log("Puerta bloqueada");
            door_lock=true;
            }
    }
}