using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResumeMusic : MonoBehaviour
{
    void Awake()
    {
        BgMusic.Instance.gameObject.GetComponent<AudioSource>().UnPause();
    }
}
