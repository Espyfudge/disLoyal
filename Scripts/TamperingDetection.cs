using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TamperingDetection : MonoBehaviour {

	public GameObject startPosCop;
	public GameObject endPosCop;
	public GameObject gcManager;
	public GameObject goPanel;
	public GameObject miniGame;
	public GameObject spooper;
	public GameObject evidence;

	float t;
    Vector2 startPosition;
    Vector2 target;
    float timeToReachTarget = 1.2f;

	private GCManager gcMan;
    private bool gameOver;
    private bool copCheck;
    private static bool quickCheck;

    private float secondsBetweenCheck;
    private float timePassed;

    private bool soundMade;

    private Animator anim;

    private float anTimer1;
    private float anTimer2;
    private float anTimer3;

    private int animPhase = 1;

	// Use this for initialization
	void Start () {
		gcMan = gcManager.GetComponent<GCManager>();

		startPosition = startPosCop.transform.position;
		target = endPosCop.transform.position;

		secondsBetweenCheck = Random.Range(5,11) * 1.0f;
		//Debug.Log(secondsBetweenCheck);

		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if (gcMan.gameStart) {
			if (!copCheck) {
				timePassed += Time.deltaTime;

				if ( (timePassed >= (secondsBetweenCheck - 0.7f) ) && (!soundMade) ) {
					gameObject.GetComponent<AudioSource>().Play();
					soundMade = true;
				}
			}
			//Debug.Log("TIME:" + timePassed);

			if (timePassed >= secondsBetweenCheck) {
				copCheck = true;
				timePassed = 0;
				soundMade = false;
			}
			
			if (copCheck) {
				t += Time.deltaTime/timeToReachTarget;
				transform.position = Vector2.Lerp(startPosition, target, t);

				if ( (gameOver) && (gcMan.gpActive) && ( (animPhase == 2) || (animPhase == 3) ) ) {
					goPanel.SetActive(true);
					miniGame.SetActive(false);
					gameObject.SetActive(false);
					evidence.SetActive(true);
					spooper.SetActive(true);
					gcMan.gameStart = false;
					quickCheck = false;
				}

				if (!quickCheck) {
					StartCoroutine(AfterCheck());
				}

				//peek animations
				if (animPhase == 1) {
					anTimer1 += Time.deltaTime;
				}
				if ( (anTimer1 >= 1.2f) ) {
					anim.SetBool("movedPeek", true);
					animPhase = 2;
					anTimer1 = 0;
				}

				if (animPhase == 2) {
					anTimer2 += Time.deltaTime;
				}
				if ( anTimer2 >= 0.84f ) {
					anim.SetBool("movedPeek", false);
					anim.SetBool("peekBack", true);
					animPhase = 3;
					anTimer2 = 0;
				}

				if ( animPhase == 3 ) {
					anTimer3 += Time.deltaTime;
				}
				if ( anTimer3 >= 0.84f ) {
					anim.SetBool("peekBack", false);
					animPhase = 4;
					anTimer3 = 0;
				}
				//
			}
		}
	}

	IEnumerator AfterCheck () {
		quickCheck = true;
		yield return new WaitForSeconds(3.5f);
		secondsBetweenCheck = Random.Range(7,25) * 1.0f;
		//Debug.Log(secondsBetweenCheck);
		copCheck = false;
		t = 0;
		animPhase = 1;
		gameObject.transform.position = startPosition;
		quickCheck = false;
	}

	void OnTriggerEnter2D (Collider2D other) {
		if (other.gameObject.tag == "Game Over") {
			gameOver = true;
		}
	}

	void OnTriggerLeave2D (Collider2D other) {
		gameOver = false;
	}

}
