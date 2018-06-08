using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score : MonoBehaviour {

	public Text scoreText;
	public int ballValue;

	private int score;

	// Use this for initialization
	void Start () {
		score = 0;
		UpdateScoreText ();
	}

	void OnTriggerEnter2D(){
		score += ballValue;
		UpdateScoreText ();
	}

	void OnCollisionEnter2D(Collision2D collision){
		if (collision.gameObject.tag == "Bomb") {
			score -= ballValue * 2;
			UpdateScoreText ();
		}
	}

	void UpdateScoreText(){
		scoreText.text = "Score:\n" + score;
	}
}
