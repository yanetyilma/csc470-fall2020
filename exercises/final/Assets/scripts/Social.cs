using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Social : MonoBehaviour
{
    public Slider slider;

    public void SetMinSocial(int social)
    {
        slider.minValue = social;
        slider.value = social;
    }
    public void SetSocial(int social)
    {
        slider.value = social;
    }
}
