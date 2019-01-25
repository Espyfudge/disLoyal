using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectFound : MonoBehaviour {

	public GameObject gameWin;
	public GameObject gcManager;
	public GameObject hiddenObject;
	public GameObject evidence;
	
	public int objectCounter = 0;
	private GCManager gcMan;

	public float p1Score = 50.0f;
	public float p2Score = 50.0f;

	public bool finished;

	public GameObject[] searchObjects;
	public Text[] searchText;

	public GameObject timerBar;

	private bool itemFound;

	private int p2Counter;
   
    void Start () {
        gcMan = gcManager.GetComponent<GCManager>();
        RandomiseBuiltinArray(searchObjects);
		setActiveArray();
  		setText();
	}
	
	// Update is called once per frame
	void Update () {
		PlayerScore.OCFinished = finished;
		PlayerScore.D1Found = objectCounter;

		p1Score = p1Score + PlayerScore.F1Score;
		p2Score = p2Score + PlayerScore.F2Score;

		PlayerScore.P1score1 = p1Score;
		PlayerScore.P2score1 = p2Score;

		if ( objectCounter == 10 ) {
			finished = true;
			gcMan.gameStart = false;
			gcMan.gpActive = false;
			gameWin.SetActive(true);
			evidence.SetActive(true);
			evidence.GetComponent<BoxCollider2D> ().enabled = false;
			hiddenObject.SetActive(false);
		}

		if (p2Counter <= 10) {
			float p2Chance = Random.Range (0f,100f);
			if (p2Chance <= 70.0f) {
				p2Score -= 3.0f;
				p1Score += 3.0f;
			}
			if (p2Chance > 70.0f) {
				p2Score += 2.0f;
				p1Score -= 2.0f;
			}
			p2Counter += 1;
		}
    }

    public void timeDown() {
    	timerBar.GetComponent<TimerHandler>().gameTimer++;
    }

    public void countUp()
    {
        objectCounter++;
		p1Score -= 3.0f;
		p2Score += 3.0f;
        //Debug.Log(objectCounter);
    }

    void setActiveArray() {
		for ( int i = 0; i < 10; i++) {
        	searchObjects[i].SetActive(true);
        } 
    }

    void setText() {
    	int i = 0;
    	foreach ( Text txt in searchText) {
    		txt.text = searchObjects[i].name;
    		i++;
    	}
    }

    public static void RandomiseBuiltinArray(GameObject[] arr) {
    	for (int i = arr.Length - 1; i > 0; i--) {
    		int r = Random.Range(0,i + 1);
    		GameObject tmp = arr[i];
    		arr[i] = arr[r];
    		arr[r] = tmp;
    	}
    }
}
