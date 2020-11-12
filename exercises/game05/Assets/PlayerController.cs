using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.EventSystems;


public class PlayerController : MonoBehaviour
{
	public CharacterController controller;

	public float speed = 12f;
	public float gravity = -9.81f;
	public float jumpHeight = 3.5f;

	public Transform groundCheck;
	public float groundDistance = 0.4f;
	public LayerMask groundMask;

	Vector3 velocity;
	bool isGrounded;

	public float rayLength;
	public LayerMask layermask;

	// Update is called once per frame
	void Update()
	{
		isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

		if (isGrounded && velocity.y < 0)
		{
			velocity.y = -2f;
		}

		float x = Input.GetAxis("Horizontal");
		float z = Input.GetAxis("Vertical");

		Vector3 move = transform.right * x + transform.forward * z;

		controller.Move(move * speed * Time.deltaTime);

		if (Input.GetButtonDown("Jump") && isGrounded)
		{
			velocity.y = Mathf.Sqrt(jumpHeight * -2 * gravity);
		}

		velocity.y += gravity * Time.deltaTime;

		controller.Move(velocity * Time.deltaTime);

		if (Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject())
        {
			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			if (Physics.Raycast(ray, out hit, rayLength, layermask))
            {
				if (hit.collider.gameObject.tag == "Key")
				{
					Destroy(hit.collider.gameObject);
					SceneManager.LoadScene("player1");
				}
				if (hit.collider.gameObject.tag == "Key2")
				{
					Destroy(hit.collider.gameObject);
					SceneManager.LoadScene("player2");
				}
				if (hit.collider.gameObject.tag == "Key3")
				{
					Destroy(hit.collider.gameObject);
					SceneManager.LoadScene("player3");
				}
				if (hit.collider.gameObject.tag == "Selectable")
				{
					Destroy(hit.collider.gameObject);
					SceneManager.LoadScene("letter1");
				}
				if (hit.collider.gameObject.tag == "Selectable2")
				{
					Destroy(hit.collider.gameObject);
					SceneManager.LoadScene("letter2");
				}
				if (hit.collider.gameObject.tag == "Selectable3")
				{
					Destroy(hit.collider.gameObject);
					SceneManager.LoadScene("letter3");
				}
				if (hit.collider.gameObject.tag == "BadSelectable")
				{
					Destroy(hit.collider.gameObject);
					SceneManager.LoadScene("deathnote");
				}
				if (hit.collider.gameObject.tag == "BadSelectable2")
				{
					Destroy(hit.collider.gameObject);
					SceneManager.LoadScene("deathnote2");
				}
				if (hit.collider.gameObject.tag == "BadSelectable3")
				{
					Destroy(hit.collider.gameObject);
					SceneManager.LoadScene("deathnote3");
				}
				if (hit.collider.gameObject.tag == "Selectable1(2)")
				{
					Destroy(hit.collider.gameObject);
					SceneManager.LoadScene("letter1(2)");
				}
				if (hit.collider.gameObject.tag == "Selectable2(2)")
				{
					Destroy(hit.collider.gameObject);
					SceneManager.LoadScene("letter2(2)");
				}
				if (hit.collider.gameObject.tag == "Selectable3(2)")
				{
					Destroy(hit.collider.gameObject);
					SceneManager.LoadScene("letter3(2)");
				}
				if (hit.collider.gameObject.tag == "Selectable1(3)")
				{
					Destroy(hit.collider.gameObject);
					SceneManager.LoadScene("letter1(3)");
				}
				if (hit.collider.gameObject.tag == "Selectable2(3)")
				{
					Destroy(hit.collider.gameObject);
					SceneManager.LoadScene("letter2(3)");
				}
				if (hit.collider.gameObject.tag == "Selectable3(3)")
				{
					Destroy(hit.collider.gameObject);
					SceneManager.LoadScene("letter3(3)");
				}
				if (hit.collider.gameObject.tag == "EndKey")
				{
					Destroy(hit.collider.gameObject);
					SceneManager.LoadScene("end");
				}
				if (hit.collider.gameObject.tag == "EndKey2")
				{
					Destroy(hit.collider.gameObject);
					SceneManager.LoadScene("end2");
				}
				if (hit.collider.gameObject.tag == "EndKey3")
				{
					Destroy(hit.collider.gameObject);
					SceneManager.LoadScene("end3");
				}
			}
		}
	
	}
}
