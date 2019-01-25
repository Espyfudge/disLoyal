using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinigameUI : MonoBehaviour {
    public GameObject hiddenObjGame;
    public GameObject evidence;
    public GameObject explanationPanel; 
    public GameObject gcManager;
	public GameObject timerBar;

    private GCManager gcMan;
	// Use this for initialization
	void Start () {
		gcMan = gcManager.GetComponent<GCManager>();	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void GoBack()
    {
        hiddenObjGame.SetActive(false);
        evidence.SetActive(true);
        gcMan.gpActive = false;
    }

    public void closeExplanation () {
    	explanationPanel.SetActive(false);
		timerBar.SetActive (true);
    	gcMan.gameStart = true;
    }
}
