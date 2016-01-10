using UnityEngine;
using System.Collections;public class TitleScreen : MonoBehaviour {    
	public static bool useSwordA ;
	public static bool useSwordB ;
	public static bool useSwordC ;
	public static bool useSwordA2 ;
	public static bool useSwordB2 ;
	public static bool useSwordC2 ;
	// Use this for initialization
	void Start () {
		//manually reset nightmare mode
		useSwordA = true;
		useSwordB = false;
		useSwordC = false;
		useSwordA2 = true;
		useSwordB2 = false;
		useSwordC2 = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.A)){
			useSwordA = true;
			useSwordB = false;
			useSwordC =false;
			
		}        if(Input.GetButtonDown("SwordButton1")){
			useSwordA = true;
			useSwordB = false;
			useSwordC =false;

			useSwordA2 = true;
			useSwordB2 = false;
			useSwordC2 =false;
		}        if(Input.GetKeyDown(KeyCode.B)){
			useSwordA = false;
			useSwordB = true;
			useSwordC =false;
		}        if(Input.GetButtonDown("AxeButton1")){
			useSwordA = false;
			useSwordB = true;
			useSwordC =false;
			useSwordA2 = false;
			useSwordB2 = true;
			useSwordC2 =false;
			victoryScript.counterPlayerOne=21;
			victoryScript.counterPlayerTwo=21;
		}        if(Input.GetKeyDown(KeyCode.X)){
			useSwordA2 = true;
			useSwordB2 = false;
			useSwordC2 =false;
			
		}        if(Input.GetButtonDown("SwordButton2")){
			useSwordA2 = true;
			useSwordB2 = false;
			useSwordC2 =false;
			
		}
		if(Input.GetKeyDown(KeyCode.Y)){
			useSwordA2 = false;
			useSwordB2 = true;
			useSwordC2 =false;
		}        if(Input.GetButtonDown("AxeButton2")){
			useSwordA2 = false;
			useSwordB2 = true;
			useSwordC2 =false;
		}        if (Input.GetKeyDown(KeyCode.Space)){
			Application.LoadLevel(1);        }        if (Input.GetButtonDown("Start1") || Input.GetButtonDown("Start2")){
			Application.LoadLevel(1);
			
		}
	}
}