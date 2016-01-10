using UnityEngine;
using System.Collections;
public class moveBottomCube : MonoBehaviour {

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
		float horizontal2 = Input.GetAxis("LeftJoystick2Y");  //Left/Right or A/D
		//rotate
		//if((Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow)))
		//   {
		transform.Translate(horizontal2 * .1f, 0f, 0f);
		//}
		
		float vertical2 = Input.GetAxis("LeftJoystick2X");  //Up/Down or W/S
		//if((Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow)) && (transform.localEulerAngles.z >= 245.08 && transform.localEulerAngles.z <= 308.8))
		//if((Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow)))
		//{
		//transform.Rotate(0f, vertical, 0f);
		transform.Translate(0f, 0f, vertical2 * .1f);
		//}
		
		float lRotate2 = Input.GetAxis("LeftTrigger2");
		transform.Rotate(0f, lRotate2, 0f);
		
		float rRotate2 = Input.GetAxis("RightTrigger2");
		transform.Rotate(0f, rRotate2, 0f);
		
	}
	
}
