using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rightWingClipController : MonoBehaviour {

	public GameObject rightBrokenWing;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider other){ 



		Instantiate (rightBrokenWing, this.transform.position, this.transform.rotation, null);
		this.gameObject.SetActive (false);
	}

}
