using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class deleteObject : MonoBehaviour {

	public GameObject objCounter;
	private ObjectFound obf;
	// Use this for initialization
	void Start () {
		obf = objCounter.GetComponent<ObjectFound>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void onClick()
    {
    	foreach (Text txt in obf.searchText) {
    		if ( txt.text == gameObject.name ) {
    			txt.gameObject.SetActive(false);
    		}
    	}
        gameObject.SetActive(false);
    }
}
