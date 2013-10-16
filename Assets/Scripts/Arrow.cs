﻿using UnityEngine;
using System.Collections;

public class Arrow:MonoBehaviour {
	private int moveSpeed = 5;
	
	void Start() {
		gameObject.name = "Arrow";	
	}
	
	void FixedUpdate() {
		rigidbody.velocity = new Vector3(moveSpeed, 0, 0);
	}
	
	void OnCollisionEnter(Collision collision) {		
		if(collision.collider.name == "Player") {
			Destroy(collision.collider.gameObject);
			Application.LoadLevel(0);
		}
	}
}
