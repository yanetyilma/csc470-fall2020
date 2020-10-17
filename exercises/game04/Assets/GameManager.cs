using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    

   // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PressStart()
    {
        SceneManager.LoadScene("FlightScene");
    }
    public void PressHowToPlay()
    {
        SceneManager.LoadScene("HowToPlay");
    }
    public void PressGoBack()
    {
        SceneManager.LoadScene("WelcomeScreen");
    }
    public void PressStartOver()
    {
         SceneManager.LoadScene("WelcomeScreen");
    }
    public void PressStartOver2()
    {
        SceneManager.LoadScene("PlatformChallenge");
    }
    public void PressNextLevel()
    {
        SceneManager.LoadScene("PlatformChallenge");
    }

}
