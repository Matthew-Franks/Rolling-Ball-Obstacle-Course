using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelThreeBall : MonoBehaviour
{
	
	public GameObject northWall;
	public GameObject southWall;
	public GameObject eastWall;
	public GameObject westWall;

	public Text endLevelText;
	public Text levelThreeText;
	public Text deathsText;
	public Text trickText;

	private float speed = 10;
	private int deaths;
	private Rigidbody rb;
	private int count;

	void Start ()
	{
		rb = GetComponent<Rigidbody> ();
		count = 0;
		deaths = PlayerPrefs.GetInt ("deaths");
		deathsText.text = "Errors: " + deaths;
	}

	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement * speed);

		if (transform.position.x > 30 && transform.position.z > 61.5)
			trickText.gameObject.SetActive (true);

		if (transform.position.z > 6)
		{
			levelThreeText.gameObject.SetActive(false);
		}

		if (transform.position.y < -3)
		{
			deaths++;
			PlayerPrefs.SetInt ("deaths", deaths);
			SceneManager.LoadScene("Level 3", LoadSceneMode.Single);
		}

		if (count == 1)
		{
			PlayerPrefs.SetInt ("deaths", deaths);
			if (Input.GetKeyDown (KeyCode.Space))
				SceneManager.LoadScene("Level 4 Tutorial", LoadSceneMode.Single);
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
			endLevelText.text = "Congratulations! Press [SPACE] to advance to the next level!";
		}
	}
}
