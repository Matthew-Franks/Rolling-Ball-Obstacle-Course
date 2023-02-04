using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncingPlane : MonoBehaviour
{
	public Rigidbody rigidPlayer;

	private float speed = 10;

	void OnCollisionEnter(Collision collidedWithThis)
	{
		if (collidedWithThis.transform.name == "Sphere")
		{
			Vector3 movement = new Vector3 (0.0f, 35.0f, 0.0f);
			rigidPlayer.AddForce (movement * speed);
		}
	}
}