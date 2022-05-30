using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : Button
{
    public static bool llave;
    public static GameObject spriteKeyAux;
    public GameObject spriteKey;
    private Renderer rend2;
    private Color colorOriginal;

    public void Start(){
        llave = false;
        rend2 = GetComponent<Renderer>();
        colorOriginal = rend2.material.color;
        spriteKeyAux = spriteKey;
    }

    override public void onClickAction(){
        if (llave == true){
            Debug.Log("Es una llave");
        }

    }

    static public void activateKey(){
        llave = true;
        spriteKeyAux.SetActive(true);
        Debug.Log("Has activado la llave");
    }
    
    override public void enterZone(){
        if (llave == true){
            rend2.material.color = new Color(colorOriginal.r, colorOriginal.g, colorOriginal.b, 0f);
        }
    }
}
