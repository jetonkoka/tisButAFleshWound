using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class displayScore : MonoBehaviour {

	public TextMesh txt;
	// Use this for initialization
	void Start () 
	{
		//txt = gameObject.AddComponent<TextMesh>();
		txt.text ="Score: \nRed Robot has: " + victoryScript.counterPlayerOne.ToString() + " body parts left\nBlue Robot has: " + victoryScript.counterPlayerTwo.ToString() + " body parts left";
	}
	
	// Update is called once per frame
	void Update () 
	{
		txt.text ="Score: \nRed Robot has: " + victoryScript.counterPlayerOne.ToString() + " body parts left\nBlue Robot has: " + victoryScript.counterPlayerTwo.ToString() + " body parts left";
	}
}
