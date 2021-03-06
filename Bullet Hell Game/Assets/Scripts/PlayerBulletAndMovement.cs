﻿using System.Collections;
using UnityEngine;

[System.Serializable]
public class Boundary
{
	public float xMin, xMax, zMin, zMax;
}

public class PlayerBulletAndMovement : MonoBehaviour
{
	public float speed;
	public Boundary boundary;

	public GameObject Shot;
	public Transform BulletSpawn;
	public float fireRate;

	private float nextFire;

	void Update()
	{
		if (Time.time > nextFire) {
			nextFire = Time.time + fireRate;
			Instantiate (Shot, BulletSpawn.position, BulletSpawn.rotation);
		}
	}


	void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		var movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		var rigidbody = GetComponent<Rigidbody> ();
		rigidbody.velocity = movement * speed;

		rigidbody.position = new Vector3
			(
				Mathf.Clamp (rigidbody.position.x, boundary.xMin, boundary.xMax),
				0.0f,
				Mathf.Clamp (rigidbody.position.z, boundary.zMin, boundary.zMax)
				);
	}
}


