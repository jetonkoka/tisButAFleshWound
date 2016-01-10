using UnityEngine;
using System.Collections;

public class moveSword : MonoBehaviour 
{

	//Rigidbody rb;
	// Use this for initialization
	void Start () 
	{
		//rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKey(KeyCode.E)) 
			if(transform.localEulerAngles.y < 30f)
			{
				
				transform.Rotate(-1f,0f,0f); 
			}
			
		
		if(Input.GetKey(KeyCode.R))
			if(transform.localEulerAngles.y > 60f)
			{
			
				transform.Rotate(1f,0f,0f); 
			}
			 
		if(Input.GetKey(KeyCode.T))
		{
			if(transform.position.x < 3f)
			{
				transform.Translate(0f, 1f *.1f, 0f);
			}
		}
			
		if(Input.GetKey(KeyCode.Q)) 
		{
			if(transform.position.x > 2f)
			{
				transform.Translate(0f, -1f *.1f, 0f);
			}
		}
			

	}
}
