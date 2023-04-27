using UnityEngine;
using System.Collections;

public class HoldBall : MonoBehaviour {

	void OnTriggerStay(Collider col) {
		col.transform.parent = gameObject.transform;
	}

	void OnTriggerExit(Collider col)
	{
		col.transform.parent = null;
	}
}