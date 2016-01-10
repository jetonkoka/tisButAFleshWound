using UnityEngine;
using System.Collections;

public class SwordTest : MonoBehaviour {
	
		// Update is called once per frame
		void Update () {
			float horizontal = Input.GetAxis("Horizontal");  //Left/Right or A/D
			const float turnRate = -90f;
			//rotate
		transform.Rotate(horizontal * turnRate * Time.deltaTime, 0f, 0f);
			
			float vertical = Input.GetAxis("Vertical");  //Up/Down or W/S
		    const float turnRate2 = 90f;
		transform.Rotate(0f, 0f, vertical * turnRate2 * Time.deltaTime);
			//const float moveSpeed = 5f;
			//move
			//transform.position += transform.forward * vertical * Time.deltaTime * moveSpeed;
		}
	}

