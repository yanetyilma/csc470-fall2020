using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopMusic3 : MonoBehaviour
{
    void Awake()
    {
        BgMusic3.Instance.gameObject.GetComponent<AudioSource>().Pause();
    }
}
