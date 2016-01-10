using UnityEngine;
using System.Collections;

public class secondPlayer : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	float speed = 10f;
	// Update is called once per frame
	void Update()
	{
		if(Input.GetKey(KeyCode.I)) 
			transform.Translate(Vector3.forward * Time.deltaTime * speed);
		
		if(Input.GetKey(KeyCode.K)) 
			transform.Translate( -1 * Vector3.forward * Time.deltaTime * speed);
		
		/*if(Input.GetKey(KeyCode.J)) 
			transform.Rotate(0,-1,0); 
		
		if(Input.GetKey(KeyCode.L)) 
			transform.Rotate(0,1,0); 	*/
	}
}
