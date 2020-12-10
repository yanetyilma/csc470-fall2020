using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fun : MonoBehaviour
{
    public Slider slider;

    public void SetMinFun(int fun)
    {
        slider.minValue = fun;
        slider.value = fun;
    }
    public void SetFun(int fun)
    {
        slider.value = fun;
    }
}
