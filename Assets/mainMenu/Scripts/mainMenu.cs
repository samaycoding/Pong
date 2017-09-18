//<summary>
//Main Menu.
//Attached to Main Camera.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class mainMenu : MonoBehaviour {

    // Use this for initialization
    public Texture backgroundTexture;

     void OnGUI(){

        //Display our Background Texture
        GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height),backgroundTexture);
    }
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update() { 
		
	}
}
