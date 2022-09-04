using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseInputs : MonoBehaviour
{   
    public Texture2D cursorArrow;

    void Start(){
        Cursor.SetCursor(cursorArrow, Vector2.zero, CursorMode.ForceSoftware);
    }

    // Update is called once per frame
    void Update()
    {
        /*if(Input.GetMouseButtonDown(0)){
            Debug.Log("MouseBtn0");
        }
        if(Input.GetMouseButtonDown(1)){
            Debug.Log("MouseBtn1");
        }
        if(Input.GetMouseButtonDown(2)){
            Debug.Log("MouseBtn2");
        }*/
    }
}
