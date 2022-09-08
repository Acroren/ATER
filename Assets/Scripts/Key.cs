using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : Button
{
    public static bool llave;
    public static bool note;
    public static GameObject spriteKeyAux;
    public static GameObject spriteNoteAux;
    public GameObject spriteKey;
    public GameObject spriteNote;
    private Renderer rend2;
    private Color colorOriginal;

    public void Start(){
        llave = false;
        note = false;
        rend2 = GetComponent<Renderer>();
        colorOriginal = rend2.material.color;
        spriteKeyAux = spriteKey;
        spriteNoteAux = spriteNote;
    }

    static public void activateKey(){
        llave = true;
        spriteKeyAux.SetActive(true);
    }


    static public void desactivaKey(){
        llave = false;
        spriteKeyAux.SetActive(false);
    }

    static public void activateNote(){
        desactivaKey();
        note = true;
        spriteNoteAux.SetActive(true);
    }

    override public void enterZone(){
        if (llave || note){
            rend2.material.color = new Color(colorOriginal.r, colorOriginal.g, colorOriginal.b, 0f);
        }
    }
}
