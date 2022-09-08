using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : Button
{

    override public void onClickAction(){
        Application.Quit();
    }

    
}
