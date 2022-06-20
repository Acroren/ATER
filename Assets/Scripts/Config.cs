using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Config : Button
{

    override public void onClickAction(){
        SceneManager.LoadScene("Menu");
    }

    
}
