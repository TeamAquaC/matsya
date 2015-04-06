using UnityEngine;
using System.Collections;

public class spearSpawn : MonoBehaviour {
 	GameObject [] spearClone = new GameObject[5];
	int count = 0;
	float timer= 0.0f;
	public float spawnRate;
	public GameObject g ;
	public GameObject h;
	public GameObject boatFront;
	public GameObject boatBack;
	public Vector3 randomDirection;
	Quaternion t;
	public float spearSpeed;
	GameObject [] indicClone = new GameObject[5];


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		randomDirection = boatFront.transform.position - boatBack.transform.position;
		timer += Time.deltaTime;

		if (timer >= spawnRate - 0.4f && count < 5) 
		{
			indicator (count);
		}

		if (timer >= spawnRate && count < 5) 
		{
			spawn(count);
			count++;
			timer= 0.0f; 
			count = count % 5;
		}
	}

	void indicator (int count)
	{
		indicClone [count] = (GameObject)Instantiate (h, new Vector3 (0, 0, 0), Quaternion.identity);
	}

	void spawn(int count) 
	{
		if (spearClone [count] != null) {
			Object.Destroy( spearClone[count]);

		}
		t = Quaternion.LookRotation(randomDirection);;
		spearClone[count] = (GameObject)Instantiate (g, new Vector3 (0, 0, 0), t);
		spearClone[count].rigidbody.velocity = randomDirection * spearSpeed;


	}

}


