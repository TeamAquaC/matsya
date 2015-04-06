using UnityEngine;
using System.Collections;

public class cameraMove : MonoBehaviour {
	//float timer;
	AudioSource[] allAudios;
	float elapsedInner= 0.0f;
	float elapsedMiddle= 0.0f;
	float elapsedOuter= 0.0f;
	public GameObject midSplosion;
	private float midSplosionCount;
	public GameObject outerSplosion;
	private float outerSplosionCount;
	public GameObject finalSplosion;
	private float finalSplosionCount;
	int count = 0;
	int countStart;

	// Use this for initialization
	void Start () {
		elapsedInner = 1.0f;
		allAudios = Camera.main.gameObject.GetComponents<AudioSource>();
		allAudios [0].Play ();
		allAudios [1].volume = 0.0f;
		allAudios [1].Pause();
		allAudios [2].volume = 0.0f;
		allAudios [2].Pause();
		midSplosionCount = 0.0f;
		finalSplosionCount = 0.0f;
		outerSplosionCount = 0.0f;
		Camera.main.orthographicSize = 2.3f;
	}
	
	// Update is called once per frame
	void Update () 
	{




				GameObject [] tunaWithInnerTag = GameObject.FindGameObjectsWithTag ("innerFish");
				GameObject [] tunaWithMidTag = GameObject.FindGameObjectsWithTag ("midFish");
				GameObject [] tunaWithOuterTag = GameObject.FindGameObjectsWithTag ("outerFish");
				
		if (tunaWithOuterTag.Length == 7 && finalSplosionCount == 0.0f) {
						Instantiate (finalSplosion, new Vector3 (0, 0, 0), finalSplosion.transform.rotation);
						finalSplosionCount++;
				}
			
			if (tunaWithMidTag.Length > 5 && tunaWithInnerTag.Length > 4) {

						if (elapsedOuter == 0.0f && outerSplosionCount == 0.0f)
						{
							Instantiate (outerSplosion, new Vector3 (0, 0, 0), outerSplosion.transform.rotation);
							outerSplosionCount++;
						}
			
			elapsedInner = 0.0f;
						elapsedMiddle = 0.0f;
						elapsedOuter += Time.deltaTime;
		
						Camera.main.orthographicSize = Mathf.Lerp (3.55f, 5.2f, elapsedOuter * 0.25f);

						allAudios [2].volume += elapsedOuter * 0.001f;

						if (allAudios [2].isPlaying == false) {
								allAudios [2].Play ();
						}
						
						allAudios [0].volume -= elapsedOuter * 0.001f;
						allAudios [1].volume -= elapsedOuter * 0.001f;
						allAudios [2].volume += elapsedOuter * 0.001f;

						} else if (tunaWithInnerTag.Length > 4 && elapsedOuter == 0.0f) {

						if (elapsedMiddle == 0.0f && midSplosionCount == 0.0f)
						{
							Instantiate (midSplosion, new Vector3 (0, 0, 0), midSplosion.transform.rotation);
							midSplosionCount++;
						}

						elapsedInner = 0.0f;
						elapsedMiddle += Time.deltaTime;
						elapsedOuter = 0.0f;
			
						Camera.main.orthographicSize = Mathf.Lerp (2.3f, 3.55f, elapsedMiddle * 0.25f);
						if (allAudios [1].isPlaying == false) {
							allAudios [1].Play ();
						}
						allAudios [1].volume += elapsedMiddle * 0.001f;
						allAudios [0].volume -= elapsedMiddle * 0.001f;
						allAudios [2].volume -= elapsedMiddle * 0.001f;
			
			
				} else if (tunaWithMidTag.Length > 5 && tunaWithInnerTag.Length < 5) {

						elapsedInner += Time.deltaTime;
						elapsedMiddle = 0.0f;
						elapsedOuter = 0.0f;

						Camera.main.orthographicSize = Mathf.Lerp (5.2f, 2.3f, elapsedInner * 0.25f);
	
						if (allAudios [1].isPlaying == false) {
								allAudios [1].Play ();
						}

						allAudios [0].volume += elapsedInner * 0.001f;
						allAudios [1].volume -= elapsedInner * 0.001f;
						allAudios [2].volume -= elapsedInner * 0.001f;

				}else if (tunaWithInnerTag.Length < 5) {
			
						elapsedInner += Time.deltaTime;
						elapsedMiddle = 0.0f;
						elapsedOuter = 0.0f;
			
						Camera.main.orthographicSize = Mathf.Lerp (3.55f, 2.3f, elapsedInner * 0.25f);
			
						allAudios [0].volume += elapsedInner * 0.001f;
						allAudios [1].volume -= elapsedInner * 0.001f;
						allAudios [2].volume -= elapsedInner * 0.001f;
				} else if (tunaWithMidTag.Length < 6 && elapsedInner == 0.0f) {

						elapsedInner += 0.0f;
						elapsedMiddle += Time.deltaTime;
						elapsedOuter = 0.01f;
			
						Camera.main.orthographicSize = Mathf.Lerp (5.2f, 3.55f, elapsedMiddle * 0.25f);
			
						allAudios [0].volume -= elapsedMiddle * 0.001f;
						allAudios [1].volume += elapsedMiddle * 0.001f;
						allAudios [2].volume -= elapsedMiddle * 0.001f;


				} 
			/*


if (tunaWithInnerTag.Length > 5 && tunaWithMidTag.Length < 6) {

						elapsed += Time.deltaTime;
						Camera.main.orthographicSize = Mathf.Lerp (3.55f, 2.3f, elapsed * 0.25f);
			
						allAudios [0].volume += elapsed * 0.001f;
						allAudios [1].volume -= elapsed * 0.001f;
						allAudios [2].volume -= elapsed * 0.001f;

				} else {
						Camera.main.orthographicSize = 2.3f;
				}*/

	}
	

}


