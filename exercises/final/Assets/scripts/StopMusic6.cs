using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopMusic6 : MonoBehaviour
{
    void Awake()
    {
        BgMusic6.Instance.gameObject.GetComponent<AudioSource>().Pause();
    }
}
