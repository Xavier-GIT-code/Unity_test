using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class change_color_click : MonoBehaviour
{
    //initialization of variables
    public Color myColor;
    public Renderer myRenderer;
    
    // Start is called before the first frame update
    void Start()
    {        
        myRenderer = gameObject.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
    //Change the color of the cube when we click on the cube
       if (Input.GetMouseButtonDown(0)){
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 100.0f)){
                if (hit.transform != null){
                    if (hit.transform.gameObject){
                        //change the color of the cube
                        if( hit.transform.gameObject.tag == "cube"){                        
                            myColor = Random.ColorHSV();
                            myRenderer.material.color = myColor; 
                        }
                    }                    
                }
            }
       }
    }    
}
