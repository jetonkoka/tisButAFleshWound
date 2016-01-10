using UnityEngine;
using System.Collections;

public class moveSwordSecond : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		//rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKey(KeyCode.P)) 
			transform.Rotate(0,-1,0); 
		
		if(Input.GetKey(KeyCode.O)) 
			transform.Rotate(0,1,0); 
	}

}
