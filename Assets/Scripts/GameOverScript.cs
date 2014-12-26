using UnityEngine;
using System.Collections;

public class GameOverScript : MonoBehaviour {

	int score = 0;

	// Use this for initialization
	void Start () {
		score = PlayerPrefs.GetInt ("Score");
	}

	void OnGUI()
	{
		GUI.Label (new Rect (Screen.width / 2 - 40, 120, 80, 30), "Score: " + score);

		if (GUI.Button(new Rect(Screen.width / 2 - 30, 380, 60, 30), "Retry?"))
		{
			Application.LoadLevel("Main");
		}
	}
}
