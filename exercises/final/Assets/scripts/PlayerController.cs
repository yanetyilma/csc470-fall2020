using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerController : MonoBehaviour
{
	public CharacterController controller;

	public int maxHunger = 100;
	public int minHunger = 0;
	public int maxSocial = 100;
	public int minSocial = 0;
	public int maxHygine = 100;
	public int minHygine = 0;
	public int maxFun = 100;
	public int minFun = 0;

	public int currentHunger;
	public int currentSocial;
	public int currentHygine;
	public int currentFun;

	float currentTime = 0f;
	float startingTime = 60f;
	[SerializeField] Text countdownText;

	public Hunger hunger;
	public Social social;
	public Hygine hygine;
	public Fun fun;

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

	void Start()
    {
		currentHunger = minHunger;
		currentSocial = minSocial;
		currentHygine = minHygine;
		currentFun = minFun;

		hunger.SetMinHunger(minHunger);
		social.SetMinSocial(minSocial);
		hygine.SetMinHygine(minHygine);
		fun.SetMinFun(minFun);

		currentTime = startingTime;
	}

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
				if (hit.collider.gameObject.tag == "Fridge")
				{
					IncreaseHunger(27);
				}
				if (hit.collider.gameObject.tag == "Oven")
				{
					IncreaseHunger(47);
					DecreaseSocial(25);
				}
				if (hit.collider.gameObject.tag == "Kiko")
				{
					IncreaseSocial(40);
					DecreaseFun(15);
				}
				if (hit.collider.gameObject.tag == "Bath")
				{
					IncreaseHygine(110);
					DecreaseHunger(82);
				}
				if (hit.collider.gameObject.tag == "TV")
				{
					IncreaseFun(60);
					DecreaseHygine(33);
				}
				if (hit.collider.gameObject.tag == "Bookshelf")
				{
					IncreaseFun(35);
				}
			}
		}

		if (currentHunger >= 100 && currentSocial >= 100 && currentHygine >= 100 && currentFun >= 100)
		{
			SceneManager.LoadScene("scoreMIKOWINS1");
		}
		currentTime -= 1 * Time.deltaTime;
		countdownText.text = currentTime.ToString("0:00");
		if (currentTime <= 10)
		{
			countdownText.color = Color.red;
		}
		if (currentTime <= 0 && currentHunger != 100 && currentSocial != 100 && currentHygine != 100 && currentFun != 100)
		{
			SceneManager.LoadScene("scoreMIKOLOSES1");
		}

	}

	void IncreaseHunger(int increase)
    {
		currentHunger += increase;
		hunger.SetHunger(currentHunger);
    }
	void DecreaseHunger(int decrease)
	{
		currentHunger -= decrease;
		hunger.SetHunger(currentHunger);
	}
	void IncreaseSocial(int increase2)
	{
		currentSocial += increase2;
		social.SetSocial(currentSocial);
	}
	void DecreaseSocial(int decrease2)
	{
		currentSocial -= decrease2;
		social.SetSocial(currentSocial);
	}
	void IncreaseHygine(int increase3)
	{
		currentHygine += increase3;
		hygine.SetHygine(currentHygine);
	}
	void DecreaseHygine(int decrease3)
	{
		currentHygine -= decrease3;
		hygine.SetHygine(currentHygine);
	}
	void IncreaseFun(int increase4)
	{
		currentFun += increase4;
		fun.SetFun(currentFun);
	}
	void DecreaseFun(int decrease4)
	{
		currentFun -= decrease4;
		fun.SetFun(currentFun);
	}

}