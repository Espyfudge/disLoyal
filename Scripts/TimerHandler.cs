using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerHandler : MonoBehaviour {
	public GameObject gcManager;
	private GCManager gcMan;
	public GameObject timerBar;
	public GameObject gameWin;
	public GameObject evidence;
	public GameObject miniGame;

	private bool day2;

	public float gameTimer;
	private float timeLeft;
	private float maxTime = 60.0f;
	// Use this for initialization
	void Start () {
		gcMan = gcManager.GetComponent<GCManager> ();




	}
	
	// Update is called once per frame
	void Update () {

		if (PlayerScore.SecondDay) {
			if (!day2) {
				maxTime = 90.0f;
				//Debug.Log("it works");
				day2 = true;
			}
		}

		if (gcMan.gameStart) {
			gameTimer += Time.deltaTime;
			timeLeft = maxTime - gameTimer;
			timerBar.GetComponent<Image> ().fillAmount = timeLeft / maxTime;

			if ( (timeLeft <= 0.0f) && (!PlayerScore.OCFinished) && (!day2) ) { 
				gcMan.gameStart = false;
				gcMan.gpActive = false;
				gameWin.SetActive(true);
				evidence.SetActive(true);
				evidence.GetComponent<BoxCollider2D> ().enabled = false;
				miniGame.SetActive(false);

				int found = 12 - PlayerScore.D1Found;
				PlayerScore.F1Score = found * 2.0f;
				PlayerScore.F2Score = found * 2.0f;
			}

			if ( (timeLeft <= 0.0f) && (!PlayerScore.TCFinished) && (day2) ) {
				gcMan.gameStart = false;
				gcMan.gpActive = false;
				gameWin.SetActive(true);
				evidence.SetActive(true);
				evidence.GetComponent<BoxCollider2D> ().enabled = false;
				miniGame.SetActive(false);

				int changed = 13 - PlayerScore.D2Done;
				PlayerScore.C1Score = changed * 3.0f;
				PlayerScore.C2Score = changed * 3.0f;
			}

		}
	}
}
