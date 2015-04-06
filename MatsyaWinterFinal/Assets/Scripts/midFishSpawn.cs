using UnityEngine;
using System.Collections;

public class midFishSpawn : MonoBehaviour {
	GameObject clone;
	public int midCount = 0;
	float timer= 0.0f;
	public float midSpawnRate;
	public GameObject g ;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		GameObject [] objectsWithInnerTag = GameObject.FindGameObjectsWithTag("innerFish");
		GameObject [] objectsWithMidTag = GameObject.FindGameObjectsWithTag("midFish");
		
		if (objectsWithInnerTag.Length < 4)
		{
			timer = 0.0f;
		}
		
		timer += Time.deltaTime;
		
		if (timer >= midSpawnRate && objectsWithMidTag.Length < 7) 
		{
			spawn(midCount);
			midCount++;
			timer= 0.0f; 
			
		}
		
	}
	
	void spawn(int count) 
	{
		clone = (GameObject)Instantiate (g, new Vector3 (0, -2.8f, 0), g.transform.rotation);
		clone.transform.parent = GameObject.Find ("midRingHome").transform;
		clone.transform.localScale -= new Vector3 (.08f, .08f, .08f);
	}
	
}
