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

    private IClicked lastClick = null;

    //Inicializacion of controls and change main cursor
    private void Awake()
    {
        controls = new CursorControls();
        ChangeCursor(cursor);
        Cursor.lockState = CursorLockMode.Confined; //Confinar en la ventana
        //mainCamera = GameController.mainCamera;
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
        
    }

    private void EnableClick(){

        IClicked click = DetectObject();
        if (click != null){
            click.onClickAction();
        }
    }
    
    
    private void Update()
    {
        if( Input.GetKeyDown( KeyCode.Escape) )
           Cursor.lockState = CursorLockMode.None;

        IClicked click = DetectObject();
        if (click != lastClick && lastClick != null){
            lastClick.exitZone();
        }
        if (click != null){
            ChangeCursor(clickedCursor);
            click.enterZone();
            lastClick = click;
        }else if (lastClick != null){
            
            lastClick = null;
            ChangeCursor(cursor);
        }
    }
    
    
    private IClicked DetectObject(){
        Ray ray = mainCamera.ScreenPointToRay(controls.Mouse.Position.ReadValue<Vector2>());
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit)){
            if(hit.collider != null){
                IClicked click = hit.collider.gameObject.GetComponent<IClicked>();
                if(click != null){
                    return click;
                }
            }
        }
        return null;
    }

    private void ChangeCursor(Texture2D cursor){
        Cursor.SetCursor(cursor, cursorSize, CursorMode.Auto);
    }
}
