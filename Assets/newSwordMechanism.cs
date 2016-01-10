using UnityEngine;
using System.Collections;

public class newSwordMechanism : MonoBehaviour {


		// Update is called once per frame
	void Update () {
		float horizontal2 = Input.GetAxis("RightJoystick2X");  //Left/Right or A/D
		const float turnRate = -90f;
		//rotate
		//if((Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow)))
		//   {
		transform.Rotate(horizontal2 * turnRate * Time.deltaTime, 0f, 0f);
		//}
		
		
		float vertical2 = Input.GetAxis("RightJoystick2Y");  //Up/Down or W/S
		const float turnRate2 = 90f;
		//if((Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow)) && (transform.localEulerAngles.z >= 245.08 && transform.localEulerAngles.z <= 308.8))
		//if((Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow)))
		//{
		transform.Rotate(0f, 0f, vertical2 * turnRate2 * Time.deltaTime);
		//}
		
		//const float moveSpeed = 5f;
		//m	ove
		//transform.position += transform.forward * vertical * Time.deltaTime * moveSpeed;
		
	}
}
