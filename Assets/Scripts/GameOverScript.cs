using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameOverScript : MonoBehaviour {

	int score = 0;
	int highScore = 0;



	// Use this for initialization
	void Start () {
		score = PlayerPrefs.GetInt ("Score");
		StoreHighscore (score);
		highScore = PlayerPrefs.GetInt ("HighScore");

		// Update GUI
		Text scoreText = GameObject.Find ("ScoreValue").GetComponent<Text>();
		scoreText.text = score.ToString();
		Text highscoreText = GameObject.Find ("HighScoreValue").GetComponent<Text>();
		highscoreText.text = highScore.ToString();
	}

	void OnGUI()
	{
//		GUI.Label (new Rect (Screen.width / 2 - 40, 115, 80, 30), "Score: " + score);
//		GUI.Label (new Rect (Screen.width / 2 - 70, 135, 180, 30), "High Score: " + highScore);
	}

	void StoreHighscore(int newHighscore)
	{
		int oldHighscore = PlayerPrefs.GetInt("HighScore", 0);    
		if(newHighscore > oldHighscore)
			PlayerPrefs.SetInt("HighScore", newHighscore);
	}

	public void Restart()
	{
		Application.LoadLevel("Main");
	}

	public void Quit()
	{
		Application.Quit ();
	}
}
