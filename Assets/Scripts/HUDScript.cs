using UnityEngine;
using System.Collections;

public class HUDScript : MonoBehaviour {

	float playerScore = 0;
	float multiplier = 1.0f;
	
	// Update is called once per frame
	void Update () {
		playerScore += Time.deltaTime * multiplier;
	}

	public void IncreaseScore(int amount)
	{
		playerScore += amount * multiplier;
	}

	public void IncreaseMultiplier()
	{
			multiplier += 1;
	}

	void OnDisable()
	{
		PlayerPrefs.SetInt ("Score", (int)(playerScore * 100));
	}

	void OnGUI()
	{
		GUI.Label (new Rect (10, 10, 200, 30), "Score: " + (int)(playerScore * 100) + " (x" + multiplier + ")" );
	}
}
