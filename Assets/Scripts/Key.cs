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

    override public void onClickAction(){
        if (llave == true){
            Debug.Log("Es una llave");
        } else if (note == true){
            Debug.Log("Es una nota, en la que aparece un simbolo de una K.");
        }

    }

    static public void activateKey(){
        llave = true;
        spriteKeyAux.SetActive(true);
        Debug.Log("Has activado la llave");
    }


    static public void desactivaKey(){
        llave = false;
        spriteKeyAux.SetActive(false);
        Debug.Log("Has usado la llave");
    }

    static public void activateNote(){
        desactivaKey();
        note = true;
        spriteNoteAux.SetActive(true);
        Debug.Log("Has encontrado una nota");
    }

    override public void enterZone(){
        if (llave || note){
            rend2.material.color = new Color(colorOriginal.r, colorOriginal.g, colorOriginal.b, 0f);
        }
    }
}
