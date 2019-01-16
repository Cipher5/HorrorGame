using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {

	public float speed = 10f;
	public GameObject brokenPlane;
	Rigidbody rb;
	// Use this for initialization
	void Start () {
		rb = this.GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		rb.AddForce (Vector3.forward * speed);


	}
	void OnTriggerEnter(Collider other){ 
		
		if (other.gameObject.tag == "CrashTrigger") {
			this.gameObject.SetActive (false);
			Instantiate (brokenPlane, this.transform.position, this.transform.rotation, null);
		}
	}
}
	
