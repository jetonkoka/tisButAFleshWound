using UnityEngine;
using System.Collections;

public class ActiveSword : MonoBehaviour {
	public GameObject swordA;
	public GameObject swordB;
	public GameObject swordC;
	public GameObject swordA2;
	public GameObject swordB2;
	public GameObject swordC2;
	// Use this for initialization
	void Start () {
		if(TitleScreen.useSwordA== true){
			swordA.SetActive(true);

		}
		if(TitleScreen.useSwordB== true){
			swordB.SetActive(true);
				
		}
		if(TitleScreen.useSwordC== true){
			swordC.SetActive(true);
				
		}
		if(TitleScreen.useSwordA2== true){
			swordA2.SetActive(true);
			
		}
		if(TitleScreen.useSwordB2== true){
			swordB2.SetActive(true);
			
		}
		if(TitleScreen.useSwordC2== true){
			swordC2.SetActive(true);
			
		}

	}
	void Update(){

		if(Input.GetKeyDown (KeyCode.R)){
			Application.LoadLevel(0);//load scene number 0(go to File > Build Settings to find scene numbers)
			
		}

	}
	

}
