using UnityEngine;
using System.Collections;

public class swordcolide : MonoBehaviour {
	public GameObject stage;
	public GameObject sword;
	public GameObject cylinder;
	public GameObject itself;
	public GameObject redRobot;
	public GameObject blueRobot;
	public GameObject redAxe;
	public GameObject blueAxe;
	public AudioClip swordSlice;
	public GameObject swordOfBlueRobot;
	public GameObject cylinderOfBlueRobot;
	public GameObject swordOfBlueAxe;
	public GameObject cylinderOfBlueAxe;
	public GameObject swordOfRedAxe;
	public GameObject cylinderOfRedAxe;
	private AudioSource source;
	// Use this for initialization
	void Start () 
	{
		source = GetComponent<AudioSource>();
	}
	// Update is called once per frame
	void Update () 
	{

	}

	void OnTriggerEnter(Collider collision){
		if(collision.gameObject.transform.parent.gameObject != stage && collision.gameObject != cylinder 
		   && collision.gameObject != sword && collision.gameObject.transform.parent.gameObject != itself 
		   && collision.gameObject != swordOfBlueRobot && collision.gameObject != cylinderOfBlueRobot
		   && collision.gameObject != swordOfBlueAxe && collision.gameObject != cylinderOfBlueAxe
		   && collision.gameObject != swordOfRedAxe && collision.gameObject != cylinderOfRedAxe)
		{

			Color newColor = new Color( Random.value, Random.value, Random.value, 1.0f );
			if(collision.gameObject.transform.parent.gameObject == redRobot 
			   || collision.gameObject.transform.parent.gameObject == redAxe)
			{
				//Rigidbody temp = collision.gameObject.GetComponent(Rigidbody);
				//temp.isKinematic = false;
				collision.attachedRigidbody.isKinematic = false;
				collision.gameObject.transform.parent = null;

				collision.gameObject.GetComponent<Renderer>().material.color= newColor;
				victoryScript.counterPlayerOne--;

				source.PlayOneShot(swordSlice, 1f);
			}
			else if(collision.gameObject.transform.parent.gameObject == blueRobot
			        || collision.gameObject.transform.parent.gameObject == blueAxe)
			{
				//Rigidbody temp = collision.gameObject.GetComponent(Rigidbody);
				//temp.isKinematic = false;
				collision.attachedRigidbody.isKinematic = false;
				collision.gameObject.transform.parent = null;
				victoryScript.counterPlayerTwo--;
				collision.gameObject.GetComponent<Renderer>().material.color = newColor;
				source.PlayOneShot(swordSlice, 1f);
			}
		}

	}
}
