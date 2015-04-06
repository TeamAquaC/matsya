using UnityEngine;
using System.Collections;

public class spearGrow : MonoBehaviour {
	public float scaleRate;
	private float timer;

	// Use this for initialization
	void Start () {transform.localScale = new Vector3 (1, 1, 1);
	}
	
	// Update is called once per frame
	void Update () {

		transform.localScale = Vector3.Lerp (transform.localScale, new Vector3 (5.0f, 5.0f, 5.0f), Time.deltaTime * scaleRate);
	}
}
