using UnityEngine;
using System.Collections;

public class boat : MonoBehaviour {

	// Use this for initialization

	public Vector3 boatDirection;
	public float timer = 0.0f;
	private float degreeVariable;
	public float boatRate;
	public Vector3 spearDirection;
	public GameObject front;
	public GameObject back;
	public GameObject guiTextBox;

	void Start () 
	{
		degreeVariable = Random.Range (20, 100);
	}
	
	// Update is called once per frame
	void Update () {

		boatDirection = Vector3.forward;
		front.transform.RotateAround(Vector3.zero, Vector3.forward, boatRate * Time.deltaTime);
		back.transform.RotateAround (Vector3.zero, Vector3.forward, boatRate * Time.deltaTime);
		this.transform.Rotate(boatDirection * boatRate * Time.deltaTime);
		timer += Time.deltaTime;

		speedChange speedScript = guiTextBox.GetComponent<speedChange>();
		float speedModBoat = speedScript.speedMod;


		if (timer >= 2) {

			degreeVariable = speedModBoat * Random.Range(20,100);
		
			timer = 0.0f;
			}
		if (degreeVariable % 2 == 0)
		{
			boatRate = - degreeVariable;
		}
		else
		{
			boatRate = degreeVariable;
		}
	}
}

