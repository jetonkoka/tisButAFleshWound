using UnityEngine;
using System.Collections;

public class victoryScript : MonoBehaviour 
{
	//public GameObject one, two, three, four, five, six, seven, eight, nine, eleven, twelve, thirteen, fourteen, fifteen, sixteen, seventeen, eighteen, nineteen;
	public static int counterPlayerOne  = 19;
	public static int counterPlayerTwo = 19;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(counterPlayerOne == 0)
		{
			Application.LoadLevel(2);

		}
		else if(counterPlayerTwo == 0)
		{
			Application.LoadLevel(3);

		}
	}
}
