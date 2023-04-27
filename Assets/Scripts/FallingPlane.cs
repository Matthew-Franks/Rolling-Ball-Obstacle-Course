using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlane : MonoBehaviour
{
	private Rigidbody rb;

	void Start ()
	{
		rb = GetComponent<Rigidbody> ();
	}

	void OnCollisionEnter(Collision collidedWithThis)
	{
		if (collidedWithThis.transform.name == "Sphere")
		{
			StartCoroutine(FallAfterDelay());
		}
	}

	IEnumerator FallAfterDelay()
	{
		yield return new WaitForSeconds(0.65f);
		rb.isKinematic = false;
	}
}