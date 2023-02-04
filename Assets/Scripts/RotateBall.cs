using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RotateBall : MonoBehaviour
{

	public int speed;

	private float timeCounter = 0;
	private int deaths = 0;

	void Start()
	{
		PlayerPrefs.SetInt ("deaths", deaths);
	}

	void Update ()
	{
		timeCounter += Time.deltaTime * speed;

		float x = Mathf.Cos (timeCounter);
		float y = 0;
		float z = Mathf.Sin (timeCounter);
		transform.position = new Vector3 (x, y, z);

		if (Input.GetKeyDown (KeyCode.Space))
			SceneManager.LoadScene("Level 1 Tutorial", LoadSceneMode.Single);
	}
}
