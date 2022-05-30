using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    public int targetFrameRate = 30;
    public static Camera mainCamera;

    private void Awake() {
        mainCamera = Camera.main;
    }
    
    private void Start()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = targetFrameRate;
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