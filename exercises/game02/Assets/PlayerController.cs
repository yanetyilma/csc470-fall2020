using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    float speed = 60f;
    float rotateSpeed = 100f;
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
        transform.Rotate(0, hAxis * rotateSpeed * Time.deltaTime, 0);

        transform.Translate(transform.forward * Time.deltaTime * speed);


    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Hearts"))
        {
            Destroy(other.gameObject);

            score++;
            scoreText.text = score.ToString();

        }
        
    }

}
