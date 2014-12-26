using UnityEngine;
using System.Collections;

public class PowerUpScript : MonoBehaviour {

	HUDScript hud;

	// Audio
	private float lowPitchRange = 0.5f;
	private float highPitchRange = 1.5f;
	public AudioClip nomSound;

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player")
		{
			// Play sound
			float vol = Random.Range (lowPitchRange,highPitchRange);
			AudioSource.PlayClipAtPoint(nomSound, this.transform.position, vol);

			// Increase score
			hud = GameObject.Find ("Main Camera").GetComponent<HUDScript>();
			hud.IncreaseScore(10);

			Destroy (this.gameObject);
		}
	}
}
