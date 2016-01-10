using UnityEngine;
using System.Collections;

public class restartGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKeyDown(KeyCode.R))
		{
			victoryScript.counterPlayerOne  = 19;
			victoryScript.counterPlayerTwo = 19;
			Application.LoadLevel(0);
		}

		if (Input.GetButtonDown("Start1") || Input.GetButtonDown("Start2"))
		{
			victoryScript.counterPlayerOne  = 19;
			victoryScript.counterPlayerTwo = 19;
			Application.LoadLevel(0);
		}
	}
}
