using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.AccessControl;
using System.Security.Cryptography;
using UnityEngine;


public class UnicornController : MonoBehaviour
{
	float moveSpeed = 8;
	float rotateSpeed = 105;

	public CharacterController cc;

	bool prevIsGrounded = false;

	float yVelocity = 0;
	float jumpForce = 0.2f;
	float gravityModifier = 0.2f;

	// Start is called before the first frame update
	void Start()
	{
		cc = gameObject.GetComponent<CharacterController>();
	}

	// Update is called once per frame
	void Update()
	{
		float hAxis = Input.GetAxis("Horizontal");
		float vAxis = Input.GetAxis("Vertical");

		transform.Rotate(0, hAxis * rotateSpeed * Time.deltaTime, 0);

		if (!cc.isGrounded)
		{
			yVelocity = yVelocity + Physics.gravity.y * gravityModifier * Time.deltaTime;
			if (Input.GetKeyUp(KeyCode.Space) && yVelocity > 0)
			{
				yVelocity = 0;
			}
		}
		else
		{
			if (!prevIsGrounded)
			{
				yVelocity = 0;
			}
			if (Input.GetKeyDown(KeyCode.Space))
			{
				yVelocity = jumpForce;
			}
		}
		Vector3 amountToMove = transform.forward * vAxis * moveSpeed * Time.deltaTime;

		amountToMove.y = yVelocity;

		
		cc.Move(amountToMove);

		prevIsGrounded = cc.isGrounded;
	}

}

