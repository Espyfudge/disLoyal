using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ClickNextScene : MonoBehaviour {
    public GameObject miniGame;
    public GameObject instructionText;
    public GameObject gcManager;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            miniGame.SetActive(true);
            gameObject.SetActive(false);
			instructionText.SetActive(false);
			gcManager.GetComponent<GCManager>().gpActive = true;
        }
    }


}
