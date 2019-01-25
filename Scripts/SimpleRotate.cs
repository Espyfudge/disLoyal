using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleRotate : MonoBehaviour {

	public GameObject rotateObject;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.RotateAround(rotateObject.transform.position, Vector3.back, 6f * Time.deltaTime);
	}
}
