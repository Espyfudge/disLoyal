using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPlayerScores : MonoBehaviour {

	// Use this for initialization
	void Start () {
  		PlayerScore.P1score1 = 0.0f;
		PlayerScore.P1score2 = 0.0f;
		PlayerScore.P2score1 = 0.0f;
		PlayerScore.P2score2 = 0.0f;
		PlayerScore.SecondDay = false;
		PlayerScore.TCFinished = false;
		PlayerScore.OCFinished = false;
		PlayerScore.D1Found = 0;
		PlayerScore.D2Done = 0;
		PlayerScore.F1Score = 0.0f;
		PlayerScore.F2Score = 0.0f;
		PlayerScore.C1Score = 0.0f;
		PlayerScore.C2Score = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
