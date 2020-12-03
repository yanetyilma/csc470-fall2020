using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResumeMusic2 : MonoBehaviour
{
    void Awake()
    {
        BgMusic2.Instance.gameObject.GetComponent<AudioSource>().Play();
    }
}