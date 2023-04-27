using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushingPlatform : MonoBehaviour {

	public string direction;
	public Rigidbody rigidPlayer;

	void OnTriggerStay(Collider col)
	{
		if (col.transform.name == "Sphere")
		{
			if (direction == "right")
			{
				Vector3 movement = new Vector3 (6.0f, 0.0f, 0.0f);
				rigidPlayer.AddForce (movement);
			}
			else if (direction == "left")
			{
				Vector3 movement = new Vector3 (-6.0f, 0.0f, 0.0f);
				rigidPlayer.AddForce (movement);
			}
			else if (direction == "forward")
			{
				Vector3 movement = new Vector3 (0.0f, 0.0f, 6.0f);
				rigidPlayer.AddForce (movement);
			}
			else if (direction == "backward")
			{
				Vector3 movement = new Vector3 (0.0f, 0.0f, -6.0f);
				rigidPlayer.AddForce (movement);
			}
		}
	}
}