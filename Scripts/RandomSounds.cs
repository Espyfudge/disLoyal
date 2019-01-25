using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSounds : MonoBehaviour {

	public GameObject gcMan;

	public GameObject footsteps;
	public GameObject vent;
	public GameObject door;

	private float nextSound;
	private int whichSound;
	private float timePassed;
	private bool soundMade;
	// Use this for initialization
	void Start () {
		nextSound = Random.Range(7f,13f);
		whichSound = Random.Range(1,4);
	}
	
	// Update is called once per frame
	void Update () {
		if (gcMan.GetComponent<GCManager>().gameStart) {
			
			timePassed += Time.deltaTime;
			if ( (timePassed >= nextSound ) ) {
				if ( whichSound == 1 ) {
					footsteps.GetComponent<AudioSource>().Play();
					footsteps.GetComponent<AudioSource>().panStereo = Random.Range(-100, 100) * 0.01f;
				}
				if ( whichSound == 2 ) {
					vent.GetComponent<AudioSource>().Play();
				}
				if ( whichSound == 3 ) {
					door.GetComponent<AudioSource>().Play();
					door.GetComponent<AudioSource>().panStereo = Random.Range(-100, 100) * 0.01f;
				}
				whichSound = Random.Range(1,4);
				nextSound = Random.Range(7f,13f);
				//Debug.Log("sound = " + whichSound);
				timePassed = 0;
			}

		}
	}
}
