using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopMusic : MonoBehaviour
{
    void Awake()
    {
        BgMusic.Instance.gameObject.GetComponent<AudioSource>().Pause();
    }
}
