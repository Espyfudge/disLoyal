using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FeedbackText : MonoBehaviour {

	public GameObject fbText;
	public GameObject day2Button;
	public GameObject mainButton;
	public GameObject endText;

	private float p1Score1;
	private float p1Score2;
	private float p2Score1;
	private float p2Score2;
	private float f1Score;
	private float p2Score;
	private bool dayTwoDone;
	private float finalScore;
	private Text fb;
	private Text end;
	// Use this for initialization
	void Start () {
		p1Score1 = PlayerScore.P1score1;
		p1Score2 = PlayerScore.P1score2;
		p2Score1 = PlayerScore.P2score1;
		p2Score2 = PlayerScore.P2score2;
		dayTwoDone = PlayerScore.SecondDay;

		if (dayTwoDone) {
			day2Button.SetActive (false);
			mainButton.SetActive (true);
			finalScore = (p1Score1 + p1Score2) / 2;
			p2Score = (p2Score1 + p2Score2) / 2;
			fbText.SetActive(false);
			endText.SetActive(true);
		}

		f1Score = p1Score1;
		fb = fbText.GetComponent<Text> ();
		end = endText.GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (f1Score < 34.0f) {
			fb.text = "I heard people saying that you might have your sentence reduced. How did you do that? I wonder what will happen to your friend. I hope you didn't rat him out, because rats don't survive very long in prison...";
		}
		if (f1Score >= 34.0f && f1Score <= 67.0f) {
			fb.text = "You are really waiting for your lawyer, aren't you? Because I heard no significant changes to your sentence yet. He's not going to save you, you know? Your future is in your own hands."; 
		}
		if (f1Score > 67.0f) {
			fb.text = "I heard people saying that you might be going to jail for a looooong time. Longer than the initial sentence. I wonder how that happened... Maybe your friend ratted you out?";
		}

		if ( finalScore <= 10.0f ) {
			end.text = "Seems like you'll go free. For some reason we don't have any evidence incriminating you.";
		}
		if ( finalScore > 10.0f && finalScore <= 20.0f) {
			end.text = "You'll probably end up only being given a community sentence. Seems like we don't have enough to pin you to the crime fully."; 
		}
		if ( finalScore > 20.0f && finalScore <= 30.0f) {
			end.text = "Rumours are you're going away for 3 years for accessory to murder. Yikes!";
		}
		if ( finalScore > 30.0f && finalScore <= 40.0f) {
			end.text = "They're expecting you to go away for 8 years. Wow! Guess they've got solid proof that you have been an accessory to murder.";
		}
		if ( finalScore > 40.0f && finalScore <= 50.0f) {
			end.text = "Just heard my colleagues talk about having enough evidence to send you to prison for 10 years for accessory to murder.";
		}
		if ( finalScore > 50.0f && finalScore <= 60.0f) {
			end.text = "You're gonna be charged for first degree murder. Guess you are a scary fellow after all. I heard they've got enough evidence to put you in jail for 15 years!";
		}
		if ( finalScore > 60.0f && finalScore <= 70.0f) {
			end.text = "Today is not your lucky day, pal. They're saying you'll be put behind bars for 25 years for first degree murder.";
		} 
		if ( finalScore > 70.0f && finalScore <= 80.0f) {
			end.text = "Can't say you don't deserve the 40 year sentence they're expecting you to serve.";
		}
		if (finalScore > 80.0f && finalScore <= 90.0f) {
			end.text = "Tough luck, buddy. You're going away for life due to the gruesome circumstances of the murder.";
		}
		if (finalScore > 90.0f) {
			end.text = "There's an overwhelming amount of evidence against you. You're charged with first degree murder. People are talking about the death penalty.";
		}
	}
}
