﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {

	public float walkSpeed;
	Rigidbody rb;
	Vector3 moveDirection;
	// Use this for initialization
	void Awake() {

		rb = GetComponent<Rigidbody> ();
	}

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float horizontalMovement = Input.GetAxisRaw ("Horizontal");
		float verticalMovement = Input.GetAxisRaw ("Vertical");

		moveDirection = (horizontalMovement * transform.right + verticalMovement * transform.forward).normalized;
	}

	void FixedUpdate () {
		Move ();
	}

	void Move() {
		Vector3 yVelFix = new Vector3(0, rb.velocity.y, 0);
		rb.velocity = moveDirection * walkSpeed * Time.deltaTime;
		rb.velocity += yVelFix;
	}
}