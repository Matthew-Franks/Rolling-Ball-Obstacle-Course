using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelOneTutorial : MonoBehaviour
{

	public GameObject northWall;
	public GameObject southWall;
	public GameObject eastWall;
	public GameObject westWall;
	public float speed;
	public Text endLevelText;
	public Text levelOneTutorialText;

	private Rigidbody rb;
	private int count;

	void Start ()
	{
		rb = GetComponent<Rigidbody> ();
		count = 0;
	}

	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement * speed);

		if (transform.position.z > 6)
		{
			levelOneTutorialText.gameObject.SetActive(false);
		}

		if (transform.position.y < -3)
		{
			SceneManager.LoadScene("Level 1 Tutorial", LoadSceneMode.Single);
		}

		if (count == 1)
		{
			if (Input.GetKeyDown (KeyCode.Space))
				SceneManager.LoadScene("Level 1", LoadSceneMode.Single);
		}
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("Token"))
		{
			northWall.gameObject.SetActive (true);
			southWall.gameObject.SetActive (true);
			westWall.gameObject.SetActive (true);
			eastWall.gameObject.SetActive (true);
			other.gameObject.SetActive(false);
			count++;
			endLevelText.text = "Awesome! Press [SPACE] to advance to the first level!";
		}
	}
}
