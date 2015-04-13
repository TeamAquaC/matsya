using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class speedChange : MonoBehaviour {

Text instruction;
public float speedMod;

	// Use this for initialization
	void Start () {
		instruction = GetComponent<Text>();
		instruction.text = "Normal";
		speedMod = .6f;
	}
	
	// Update is called once per frame
	void Update () {

	if(Input.GetKeyDown ("1")){
		instruction.text = "Fastest";
		speedMod = 1.0f;
	}

	if(Input.GetKeyDown ("2")){
		instruction.text = "Faster";
		speedMod = .75f;
	}

	if(Input.GetKeyDown ("3")){
		instruction.text = "Normal";
		speedMod = .55f;
	}

	if(Input.GetKeyDown ("4")){
		instruction.text = "Slower";
		speedMod = .3f;
	}

	if(Input.GetKeyDown ("5")){
		instruction.text = "Slowest";
		speedMod = .1f;
	}
	}
}
