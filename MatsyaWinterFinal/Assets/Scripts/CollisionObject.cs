using UnityEngine;
using System.Collections;

public class CollisionObject : MonoBehaviour {



	void OnTriggerEnter(Collider coll)
	{

			Destroy(coll.gameObject);
			Debug.Log("Collision");
			

	}
}
