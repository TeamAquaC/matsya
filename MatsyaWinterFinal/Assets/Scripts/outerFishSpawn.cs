using UnityEngine;
using System.Collections;

public class outerFishSpawn : MonoBehaviour {
	GameObject clone;
	public int outerCount = 0;
	float timer= 0.0f;
	public float outerSpawnRate;
	public GameObject g ;
	
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		GameObject [] objectsWithMidTag = GameObject.FindGameObjectsWithTag("midFish");
		GameObject [] objectsWithOuterTag = GameObject.FindGameObjectsWithTag("outerFish");
		
		if (objectsWithMidTag.Length < 6)
		{
			timer = 0.0f;
		}
		
		timer += Time.deltaTime;
		
		if (timer >= outerSpawnRate && objectsWithOuterTag.Length < 7) 
		{
			spawn(outerCount);
			outerCount++;
			timer= 0.0f; 
			
		}
		
	}
	
	void spawn(int count) 
	{
		clone = (GameObject)Instantiate (g, new Vector3 (0, -4.4f, 0), g.transform.rotation);
		clone.transform.parent = GameObject.Find ("largeRingHome").transform;
	}
	
}