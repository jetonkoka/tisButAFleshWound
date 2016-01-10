using UnityEngine;
using UnityEngine.UI;

using System.Collections;

public class displayRedScore : MonoBehaviour {

	public Text txt;
	// Use this for initialization
	void Start () 
	{
		txt = gameObject.GetComponent<Text>();
		txt.text ="Red Robot has: " + victoryScript.counterPlayerTwo.ToString() + " body parts left";
	}
	
	// Update is called once per frame
	void Update () 
	{
		txt.text ="Red Robot has: " + victoryScript.counterPlayerTwo.ToString() + " body parts left";
	}
}
