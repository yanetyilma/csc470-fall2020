using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
	public Rigidbody rb;

	float speed = 10;
	float maxSpeed = 30;
	float forwardSpeed = 3;
	float pitchSpeed = 100;
	float pitchModSpeedRate = 10f;
	float rollSpeed = 100;

	int score = 0;
	public Text scoreText;

	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		float hAxis = Input.GetAxis("Horizontal");
		float vAxis = Input.GetAxis("Vertical");

		// Rotate the plane based on input.
		float xRot = vAxis * pitchSpeed * Time.deltaTime;
		float yRot = hAxis * rollSpeed / 4 * Time.deltaTime;
		float zRot = -hAxis * rollSpeed * Time.deltaTime;
		transform.Rotate(xRot, yRot, zRot, Space.Self);


		// Compute a modifier (forwardSpeed) based on if the plane is looking up or down.
		// If the y value of the tranform's forward is positive, we know we are looking up, 
		// if it is negative, we know we are looking down.
		forwardSpeed += -transform.forward.y * pitchModSpeedRate * Time.deltaTime;
		// Make sure we never to too fast and that forwardSpeed never goes below zero.
		forwardSpeed = Mathf.Clamp(forwardSpeed, 0, 5f);

		// Move forward as modified by forwardSpeed and speed.
		transform.Translate(transform.forward * speed * forwardSpeed * Time.deltaTime, Space.World);

		// Make sure we never go below the ground. First, we find out what the height of the terrain is at
		// the position the plane is in. If the plane's y position is below that position, we know we have gone
		// too low. In the if statement, we simply place the plane at the height of the terrain.
		// But this is where you could have the plane crash, or have it slow down, or something.
		float terrainHeight = Terrain.activeTerrain.SampleHeight(transform.position);

		if (transform.position.y < terrainHeight)
		{
			transform.position = new Vector3(transform.position.x, terrainHeight, transform.position.z);
		}

		if (score >= 4)
		{
			SceneManager.LoadScene("PlatformChallenge");
		}

	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("RainbowJetpacks"))
		{
			speed = Mathf.Clamp(speed + 8, 0, maxSpeed);

			Destroy(other.gameObject);
			
		}

		if (other.CompareTag("Rainbows"))
		{
			Destroy(other.gameObject);

			score++;
			scoreText.text = score.ToString();

		}


	}

}