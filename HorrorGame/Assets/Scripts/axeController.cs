using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class axeController : MonoBehaviour {

	public float speed = 10f;
	positionReset;

	// Use this for initialization
	void Start () {
		positionReset = this.transform.rotation
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			transform.Rotate (Vector3.up, speed * Time.deltaTime);
		}
	}
}
