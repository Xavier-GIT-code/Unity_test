using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle_mouvement : MonoBehaviour
{
    //initialization of variables  
    public float timeCounter = 0;
    public float length = 3f;
    public float width =  3f;
    public float speed = 1f;
  
    // Update is called once per frame
    void Update()
    {
      // change the speed of the ball by pressing on "1","2","3" 
      if (Input.GetKeyUp (KeyCode.Keypad1)){
        speed = 1f;
      }

      if (Input.GetKeyUp (KeyCode.Keypad2)){
        speed = 3f;
      }

      if (Input.GetKeyUp (KeyCode.Keypad3)){
        speed = 9f;
      }

      //circular movement of the ball
      timeCounter+= Time.deltaTime*speed; // interval in seconds between the last frame and the current one
      float x =  length*Mathf.Cos(timeCounter);
      float y = 0.5f;
      float z = width*Mathf.Sin(timeCounter); ;
      transform.position = new Vector3 (x,y,z); // update the new position of the ball


        
    }






   
}


