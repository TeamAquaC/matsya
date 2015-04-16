using UnityEngine;
using System.Collections;

public class outerFishSwim : MonoBehaviour {
	
	
	private int speed;
	public float newSpeed;
	public GameObject clone;
	public GameObject guiTextBox;

	void Start () 
	{
		//Reference fish doesnt swim.
		//Other fish swim at random speed.

		innerFishSpawn innerRing = clone.GetComponent<innerFishSpawn> ();
		int countStart = innerRing.count;
		
		if (countStart == 0) 
		{
			speed = 0;
		} 
		else 
		{
			speed = Random.Range (5, 20);
		}
		
		
		if (speed % 2 == 0)
		{
			newSpeed = -speed;
			this.transform.Rotate (new Vector3(0, 180 , 0));
		}
		
		else
		{
			newSpeed = speed;
		}
		
	}
	
	
	// Update is called once per frame
	void Update () {
		//Define circular motion of fish

		speedChange speedScript = guiTextBox.GetComponent<speedChange>();
		float speedModOutFish = speedScript.speedMod;
		transform.RotateAround (Vector3.zero, Vector3.forward, speedModOutFish * newSpeed * Time.deltaTime);
		
	}
}



