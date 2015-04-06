using UnityEngine;
using System.Collections;

public class innerFishSwim : MonoBehaviour {


	private int speed;
	public float newSpeed;
	public GameObject clone;

	void Start () 
	{
		innerFishSpawn innerRing = clone.GetComponent<innerFishSpawn> ();
		int countStart = innerRing.count;

		if (countStart == 0) 
		{
			speed = 0;
		} 
		else 
		{
			speed = Random.Range (10, 40);
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

		// Spin the object around the world origin at 20 degrees/second.
		transform.RotateAround (Vector3.zero, Vector3.forward, newSpeed * Time.deltaTime);
		
	}
}



