using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hint3 : Button
{
    public static bool note;
    public static GameObject spriteNoteAux;
    public GameObject spriteNote;
    private Renderer rend2;
    private Color colorOriginal;

    public void Start(){
        note = false;
        rend2 = GetComponent<Renderer>();
        colorOriginal = rend2.material.color;
        spriteNoteAux = spriteNote;
    }

    static public void activateNote(){
        note = true;
        spriteNoteAux.SetActive(true);
        Debug.Log("Has encontrado una nota");
    }

    override public void enterZone(){
        if (note){
            rend2.material.color = new Color(colorOriginal.r, colorOriginal.g, colorOriginal.b, 0f);
        }
    }
}
