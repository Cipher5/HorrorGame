using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {

	public float speed = 10f;
	public Transform target;
	public GameObject brokenPlane;
	Rigidbody rb;
	// Use this for initialization
	void Start () {
		rb = this.GetComponent<Rigidbody> ();
	}

	// Update is called once per frame
	void Update () {
		//rb.AddForce (Vector3.forward * speed);

		if (Input.GetKey("a"))
		{
			transform.Rotate(Vector3.down * speed * Time.deltaTime, Space.World);
		}
		if (Input.GetKey("d"))
		{
			transform.Rotate(Vector3.up * speed * Time.deltaTime, Space.World);
		}
		if (Input.GetKey("w"))
		{
			transform.Rotate(Vector3.right * speed * Time.deltaTime);

		}
		if (Input.GetKey("s"))
		{
			transform.Rotate(Vector3.left * speed * Time.deltaTime);

		}


		float step = speed * Time.deltaTime;

		transform.position = Vector3.MoveTowards (transform.position, target.position, step);


	}
	void OnTriggerEnter(Collider other){ 
		
		//if (other.gameObject.tag == "CrashTrigger") {

			Instantiate (brokenPlane, this.transform.position, this.transform.rotation, null);
			this.gameObject.SetActive (false);
		//}
	}
}

	
