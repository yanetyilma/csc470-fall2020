using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopMusic5 : MonoBehaviour
{
    void Awake()
    {
        BgMusic5.Instance.gameObject.GetComponent<AudioSource>().Pause();
    }
}
