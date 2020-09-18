using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using Random = UnityEngine.Random;
//using System.Random;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject heartPrefab;
    public GameObject moonPrefab;
    public GameObject starPrefab;
    GameObject ground;

    float makeMoonTimer = 1.5f;
    float makeMoonRate = 1.5f;

    float makeStarTimer = 1f;
    float makeStarRate = 1f;

    // Start is called before the first frame update
    void Start()
    {
        ground = GameObject.Find("Ground");

    }

    // Update is called once per frame
    void Update()
    {
        makeMoonTimer -= Time.deltaTime;
        if (makeMoonTimer < 0)
        {
            Vector3 pos = new Vector3(ground.transform.position.x + Random.Range(-10, 10)
                                , ground.transform.position.y + 250,
                                ground.transform.position.z + Random.Range(-10, 10));

            GameObject drop = Instantiate(moonPrefab, pos, Quaternion.identity);

            Destroy(drop, 7f);

            //Reset timer
            makeMoonTimer = makeMoonRate;
        }
        makeStarTimer -= Time.deltaTime;
        if (makeStarTimer < 0)
        {
            Vector3 pos = new Vector3(ground.transform.position.x + Random.Range(-20, 20)
                                , ground.transform.position.y + 250,
                                ground.transform.position.z + Random.Range(-20, 20));

            GameObject drop = Instantiate(starPrefab, pos, Quaternion.identity);

            Destroy(drop, 7f);

            //Reset timer
            makeStarTimer = makeStarRate;

        }

    }

    public void MakeMoreHearts()
    {
        Vector3 pos = new Vector3(ground.transform.position.x + Random.Range(-20, 20)
            , ground.transform.position.y + 250,
            ground.transform.position.z + Random.Range(-20, 20));
        Instantiate(heartPrefab, pos, Quaternion.identity);
    }

    public void PressStart()
    {
        SceneManager.LoadScene("level");
    }
}
