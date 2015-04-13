using UnityEngine;
using System.Collections;

public class spearSpawn : MonoBehaviour {
 	GameObject [] spearClone = new GameObject[5];
	int count = 0;
	float timer= 0.0f;
	public float spawnRate;
	private float newSpawnRate;
	public GameObject g ;
	public GameObject h;
	public GameObject boatFront;
	public GameObject boatBack;
	public Vector3 randomDirection;
	Quaternion t;
	public float spearSpeed;
	GameObject [] indicClone = new GameObject[5];
	public GameObject guiTextBox;

	// Use this for initialization
	void Start () {
		spawnRate = 7.0f;
	}
	
	// Update is called once per frame
	void Update () {

		speedChange speedScript = guiTextBox.GetComponent<speedChange>();
		float speedModSpearSpawn = speedScript.speedMod;

		newSpawnRate = spawnRate;

		randomDirection = boatFront.transform.position - boatBack.transform.position;
		timer += Time.deltaTime;

		if (timer >= (newSpawnRate - .4f) && count < 5) 
		{
			indicator (count);
		}

		if (timer >= newSpawnRate && count < 5) 
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
		speedChange speedScript = guiTextBox.GetComponent<speedChange>();
		float speedModSpear = speedScript.speedMod;

		if (spearClone [count] != null) {
			Object.Destroy( spearClone[count]);

		}
		t = Quaternion.LookRotation(randomDirection);;
		spearClone[count] = (GameObject)Instantiate (g, new Vector3 (0, 0, 0), t);
		spearClone[count].rigidbody.velocity = speedModSpear * randomDirection * spearSpeed;


	}

}


