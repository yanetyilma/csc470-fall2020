using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopMusic4 : MonoBehaviour
{
    void Awake()
    {
        BgMusic4.Instance.gameObject.GetComponent<AudioSource>().Pause();
    }
}
