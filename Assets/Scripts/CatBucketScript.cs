using UnityEngine;
using System.Collections;

public class CatBucketScript : MonoBehaviour {

	HUDScript hud;
	
	// Audio
	private float lowPitchRange = 0.5f;
	private float highPitchRange = 1.5f;
	public AudioClip clip;
	
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player")
		{
			// Play sound
			float vol = Random.Range (lowPitchRange,highPitchRange);
			AudioSource.PlayClipAtPoint(clip, this.transform.position, vol);
			
			// Increase score
			hud = GameObject.Find ("Main Camera").GetComponent<HUDScript>();
			hud.IncreaseMultiplier();
			
			Destroy (this.gameObject);
		}
	}
}
