using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CursorController : MonoBehaviour
{
    [SerializeField, Tooltip("Main Cursor")]
    public Texture2D cursor;

    [SerializeField, Tooltip("Clicked Cursor")]
    public Texture2D clickedCursor;

    [SerializeField, Tooltip("Cursor Size")]
    public Vector2 cursorSize;

    private CursorControls controls;

    private Camera mainCamera;
    //Inicializacion of controls and change main cursor
    private void Awake()
    {
        controls = new CursorControls();
        ChangeCursor(cursor);
        Cursor.lockState = CursorLockMode.Confined; //Confinar en la ventana
        mainCamera = Camera.main;
        //Cursor.SetCursor(cursor, Vector2.zero, CursorMode.Auto);
    }
    
    private void OnEnable() {
        controls.Enable(); 
    }
    
    private void OnDisable() {
        controls.Disable();
    }

    void Start()
    {
        controls.Mouse.Click.started +=_=> StartedClick();
        controls.Mouse.Click.performed +=_=> EnableClick();
    }

    private void StartedClick(){
        ChangeCursor(clickedCursor);
    }

    private void EnableClick(){
        ChangeCursor(cursor);
        DetectObject();
        IClicked click = DetectObject();
        if (click != null){
            click.onClickAction();
        }
    }

    private IClicked DetectObject(){
        //Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        Ray ray = mainCamera.ScreenPointToRay(controls.Mouse.Position.ReadValue<Vector2>());
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit)){
            if(hit.collider != null){
                IClicked click = hit.collider.gameObject.GetComponent<IClicked>();
                if(click != null){
                    //click.onClickAction();
                    return click;
                }
                //Debug.Log("tocado" + hit.collider.gameObject.name);
            }
        }
        return null;
        
        /*
        if (Physics.Raycast(ray, out hit)){
            if(hit.collider != null){
                Debug.Log("tocado" + hit.collider.gameObject.name);
            }
        }
        */
        /*
        if (Physics.Raycast(ray, out hit)){
            if(hit.collider.tag == "Chair"){
                hit.collider.gameObject.GetComponent<Chair>().onClickChair();
            }
            if(hit.collider.gameObject.name == "Door"){
                hit.collider.gameObject.GetComponent<Door>().onClickDoor();
            }
            if(hit.collider.gameObject.name == "Desk"){
                hit.collider.gameObject.GetComponent<Desk>().onClickDesk();
            }
        }
        */
        //Comprobar todo lo que pueda tocar el rayo a una distancia de 200
        /*
        RaycastHit[] hits = Physics.RaycastAll(ray, 200);
        for(int i = 0; i < hits.Length; ++i){
            if (hits[i].collider != null){
                Debug.Log("tocado all?" + hits[i].collider.gameObject.name);
            }
        }
        */
    }

    private void ChangeCursor(Texture2D cursor){
        Cursor.SetCursor(cursor, cursorSize, CursorMode.Auto);
    }
    
    private void Update()
    {
        IClicked click = DetectObject();
        if (click != null){
            click.onZone();
        }
    }
}
