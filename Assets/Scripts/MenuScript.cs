using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour {
	
	// Audio
	private AudioSource source;
	private bool hasPlayed = false;
	public AudioClip hissSound;

	void Awake () {
		source = GetComponent<AudioSource>();
		source.clip = hissSound;
	}

	void Update() {
			if (! hasPlayed || source.isPlaying) {
					return;
			}

			Application.LoadLevel ("Main");
	}

	public void StartGame () {

		source.Play();
		hasPlayed = true;
		
	}

		
}
