using UnityEngine;
using System.Collections;
public class soundForStage : MonoBehaviour {




	public GameObject stage;
	public GameObject sword;
	public GameObject cylinder;
	public GameObject itself;
	public GameObject redRobot;
	public GameObject blueRobot;
	public GameObject redAxe;
	public GameObject blueAxe;
	public AudioClip swordSlice;
	public AudioClip axeSound;
	public AudioClip ringSound;
	public GameObject swordOfBlueRobot;
	public GameObject cylinderOfBlueRobot;
	public GameObject swordOfBlueAxe;
	public GameObject cylinderOfBlueAxe;
	public GameObject swordOfRedAxe;
	public GameObject cylinderOfRedAxe;
	private AudioSource source;

	// Use this for initialization
	void Start () {
		source = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider collision)
	{
		if(collision.gameObject.transform.parent.gameObject != stage && collision.gameObject != cylinder 
			&& collision.gameObject != sword && collision.gameObject.transform.parent.gameObject != itself 
			&& collision.gameObject != swordOfBlueRobot && collision.gameObject != cylinderOfBlueRobot
			&& collision.gameObject != swordOfBlueAxe && collision.gameObject != cylinderOfBlueAxe
			&& collision.gameObject != swordOfRedAxe && collision.gameObject != cylinderOfRedAxe)
		{

			source.PlayOneShot(ringSound, 1f);



		}





	}

}
