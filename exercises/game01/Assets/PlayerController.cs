using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Security.Cryptography;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
        
    }

    // Update is called once per frame
    void Update()
    {
        float speed = 0.001f;
        float x = transform.position.x + transform.forward.x * speed;
        float y = transform.position.y + transform.forward.y * speed;
        float z = transform.position.z + transform.forward.z * speed;
        transform.position = new Vector3(x, y, z);

        //transform.position = new Vector3(transform.position.x + 0.1f, transform.position.y, transform.position.z);
        //transform.Translate(0, 0, 0.1f);
    }
}
