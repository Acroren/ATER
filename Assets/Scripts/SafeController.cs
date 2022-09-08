using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafeController : MonoBehaviour
{
    public static int [] candidate;
    public static int [] password;
    public int[] selectPassord;
    public static int counter=0;
    public static AudioSource[] sounds;
    public static GameObject[] lights;
    public GameObject[] selectLights;
    public static Renderer renderL;
    public static bool open = false;
    public void Start()
    {
        password = selectPassord;
        candidate = new int[password.Length];
        sounds = GetComponents<AudioSource>();
        lights=selectLights;
    }

    public static void press(int value){
        if(open) return;
        candidate[counter]=value;
        if(counter == 0){
            for (int i = 1; i < lights.Length; i++){
                lights[i].GetComponent<Renderer>().material.color= Color.white;
            }
        }
        lights[counter].GetComponent<Renderer>().material.color= Color.blue;
        counter+=1;
        //If all numbers are set
        if (counter == password.Length){
            if(compare(candidate, password)){
                sounds[1].Play();
                for (int i = 0; i < lights.Length; i++){
                    lights[i].GetComponent<Renderer>().material.color= Color.green;
                }
                open=true;
                
            } else {
                sounds[0].Play();
                for (int i = 0; i < lights.Length; i++){
                    lights[i].GetComponent<Renderer>().material.color= Color.red;
                }
                Debug.Log("INCorrecto");
                counter=0;
            }
        }
    }
    
    public static bool compare(int[] arr1, int[] arr2){
        if (arr1.Length != arr2.Length)
            return false;
        for (int i = 0; i < arr2.Length; i++)
        {
            if (arr1[i] != arr2[i])
                return false;
        }
        return true;
    }
}
