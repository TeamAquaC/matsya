using UnityEngine;
using System.Collections;

public class innerTunaSpawn : MonoBehaviour {
	GameObject clone;
	public int count = 0;
	float timer= 0.0f;
	public float spawnRate;
	public GameObject g ;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		GameObject [] objectsWithTag = GameObject.FindGameObjectsWithTag("innerFish");

		if (objectsWithTag.Length > 8)
		{
			timer = 0.0f;
		}

		timer += Time.deltaTime;

		if (timer >= spawnRate && objectsWithTag.Length < 6) 
		{
			spawn(count);
			count++;
			timer= 0.0f; 

		}

	}
	
	void spawn(int count) 
	{

		clone = (GameObject)Instantiate (g, new Vector3 (0, -2, 0), g.transform.rotation);
		clone.transform.parent = GameObject.Find ("smallRingHome").transform;
		clone.transform.localScale -= new Vector3 (1f, 1f, 1f);
	}
	
}
