using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    public int targetFrameRate = 30;
    public static Camera mainCamera;
    public static bool frente = true;
    public static GameObject Room;
    public GameObject RoomAux;
    public static GameObject[] goFront;
    public static GameObject[] goBack;
    public static GameObject[] goBig;
    public static GameObject luz;
    //luz publica

    //private static string currentObjectTag = "";
    private static GameObject currentBigObject;


    private void Awake() {
        mainCamera = Camera.main;
        Room = RoomAux;
        goFront = GameObject.FindGameObjectsWithTag("Front");
        goBack = GameObject.FindGameObjectsWithTag("Back");
        goBig = GameObject.FindGameObjectsWithTag("BIG");
        luz = GameObject.FindWithTag("Light");
    }
    
    private void Start()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = targetFrameRate;
        //hide all back objects
        foreach (GameObject go in goBack)
            {
                go.SetActive(false);
            }
        //hide all big objects
        foreach (GameObject go in goBig)
            {
                go.SetActive(false);
            }
    }

    public static void rotar(){
        if (frente == true){
            mainCamera.transform.rotation = Quaternion.Euler(25, 180, 0);
            mainCamera.transform.position = new Vector3(-1, 2, -5);
            luz.transform.rotation = Quaternion.Euler(50, 180, 0);

            foreach (GameObject go in goFront)
            {
                go.SetActive(false);
            }
            foreach (GameObject go in goBack)
            {
                go.SetActive(true);
            }

            frente = false;

        } else {
            mainCamera.transform.rotation = Quaternion.Euler(25, 0, 0);
            mainCamera.transform.position = new Vector3(-1, 7, -5);
            luz.transform.rotation = Quaternion.Euler(50, 0, 0);

            foreach (GameObject go in goFront)
            {
                go.SetActive(true);
            }
            foreach (GameObject go in goBack)
            {
                go.SetActive(false);
            }
            frente = true;
        }

    }

    public static void hideObject(){
        try{
            currentBigObject.SetActive(false);
        } catch (System.Exception e){
            Debug.Log("No hay objeto activo");

        }
    }

    public static void showObject(string name){
        //Select the object to show from the array goBig
        foreach (GameObject go in goBig)
        {
            if(go.name == name){
                go.SetActive(true);
                currentBigObject = go;
            }   
        }
    }
}

/*
public class Globals
{
    private static Camera mainCamera;

    private void Awake() {
        mainCamera = Camera.main;
    }
    
}
*/