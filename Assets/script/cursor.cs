using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cursor : MonoBehaviour {

//initialization of variables
public Vector2 mousePosition; 
	
	// Use this for initialization
	void Start () {
		Cursor.visible = true; // at the begenning, the cursor is visible 
		Cursor.lockState = CursorLockMode.None;		
	}
	
	// Update is called once per frame
	void Update () {
		
		
		//press space: the cursor is locked and invisible or the opposite
		if (Input.GetKeyUp (KeyCode.Space)){
			Cursor.visible =! Cursor.visible;
			
			if(Cursor.lockState == CursorLockMode.None){
				Cursor.lockState = CursorLockMode.Locked;
			}
			else{
				Cursor.lockState = CursorLockMode.None;
			}    
		}
	}
}
