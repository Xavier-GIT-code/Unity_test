using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change_color_timer : MonoBehaviour
{
    //initialization of variables
    public float delay = 5.0f;	
    public float LastTimeLaunch = 0.0f;
    public Renderer myRenderer;
    public Color myColor;

    // Start is called before the first frame update
    void Start()
    {
        myRenderer = gameObject.GetComponent<Renderer>(); 
    }

    // Update is called once per frame
    void Update()
    {
        //set up timer to change color
        LastTimeLaunch += Time.fixedDeltaTime;  // adds to each update the time elapsed since the last update	
		if (LastTimeLaunch > delay) {
		    ChangeColor();
		    LastTimeLaunch = 0;			
	    }	
      
      //Function who change color
      void ChangeColor ()
        {		
          // what happens at all delay
            myColor = Random.ColorHSV();  
            myRenderer.material.color = myColor;      
        }  
    }
}
