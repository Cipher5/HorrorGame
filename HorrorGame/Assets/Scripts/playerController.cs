using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {

	public float speed = 10f;
	public float spinSpeed = 10f;
	public GameObject brokenPlane;
	Rigidbody rb;
	// Use this for initialization
	void Start () {
		rb = this.GetComponent<Rigidbody> ();
	}

	// Update is called once per frame
	void Update () {
		rb.AddForce (Vector3.forward * speed);

		if (Input.GetKey("left"))
		{
			transform.Rotate(Vector3.up * speed * Time.deltaTime);
		}
		if (Input.GetKey("right"))
		{
			transform.Rotate(Vector3.down * speed * Time.deltaTime);
		}
		if (Input.GetKey("up"))
		{
			transform.Rotate(Vector3.right * speed * Time.deltaTime);
			rb.AddForce (Vector3.down * speed);
		}
		if (Input.GetKey("down"))
		{
			transform.Rotate(Vector3.left * speed * Time.deltaTime);
			rb.AddForce (Vector3.up * speed);
		}


	}
	void OnTriggerEnter(Collider other){ 
		
		//if (other.gameObject.tag == "CrashTrigger") {

			Instantiate (brokenPlane, this.transform.position, this.transform.rotation, null);
			this.gameObject.SetActive (false);
		//}
	}
}

	
