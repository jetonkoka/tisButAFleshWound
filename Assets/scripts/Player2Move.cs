using UnityEngine;
using System.Collections;

public class Player2Move : MonoBehaviour {

	Rigidbody rb;
	// Use this for initialization
	void Start () 
	{
		rb = GetComponent<Rigidbody>();
	}
	float speed = 10f;
	
	//FixedUpdate is called on the same framerate that PHYSICS runs
	void Update()
	{
		float horizontal = Input.GetAxis("LeftJoystickY");  //Left/Right or A/D
		//rotate
		//if((Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow)))
		//   {
		transform.Translate(horizontal * .1f, 0f, 0f);
		//}

		float vertical = Input.GetAxis("LeftJoystickX");  //Up/Down or W/S
		//if((Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow)) && (transform.localEulerAngles.z >= 245.08 && transform.localEulerAngles.z <= 308.8))
		//if((Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow)))
		//{
		//transform.Rotate(0f, vertical, 0f);
		transform.Translate(0f, 0f, vertical * .1f);
		//}

		float lRotate = Input.GetAxis("LeftTrigger");
		transform.Rotate(0f, lRotate, 0f);
		Debug.Log (lRotate);
		//transform.Rotate(0f, 0f, lRotate);

		float rRotate = Input.GetAxis("RightTrigger");
		transform.Rotate(0f, rRotate, 0f);
		//Debug.Log (rRotate);
		
	}

}
