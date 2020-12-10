using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hygine : MonoBehaviour
{
    public Slider slider;

    public void SetMinHygine(int hygine)
    {
        slider.minValue = hygine;
        slider.value = hygine;
    }
    public void SetHygine(int hygine)
    {
        slider.value = hygine;
    }
}
