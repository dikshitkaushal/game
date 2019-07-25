using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hacker : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        ShowMainMenu();   
	}
	void ShowMainMenu()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("What do you like ? ");
        Terminal.WriteLine("Press 1 for games ");
        Terminal.WriteLine("Press 2 for painting");
        Terminal.WriteLine("Press 3 for singing");
        Terminal.WriteLine("Please enter your choice :");
        ShowMainMenu();
    }
	// Update is called once per frame
	void Update () {
		
	}
}
