using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallBounce : MonoBehaviour
{
	public string direction;
	public Rigidbody rigidPlayer;

	private float speed = 75;
	private Vector3 movement;

	void OnCollisionEnter(Collision collidedWithThis)
	{
		if (collidedWithThis.transform.name == "Sphere")
		{
			if (direction == "right")
			{
				movement = new Vector3 (35.0f, 0.0f, 0.0f);
				rigidPlayer.AddForce (movement * speed);
			}
			else if (direction == "left")
			{
				movement = new Vector3 (-35.0f, 0.0f, 0.0f);
				rigidPlayer.AddForce (movement * speed);
			}
			else if (direction == "forward")
			{
				movement = new Vector3 (0.0f, 0.0f, 35.0f);
				rigidPlayer.AddForce (movement * speed);
			}
			else if (direction == "backward")
			{
				movement = new Vector3 (0.0f, 0.0f, -35.0f);
				rigidPlayer.AddForce (movement * speed);
			}
		}
	}
}