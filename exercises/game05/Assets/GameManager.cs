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
        SceneManager.LoadScene("chooseplayer");
    }
    public void PressHowToPlay()
    {
        SceneManager.LoadScene("howtoplay");
    }
    public void PressGoBack()
    {
        SceneManager.LoadScene("titlescreen");
    }
    public void PressChooseMinnie()
    {
        SceneManager.LoadScene("Minnie");
    }
    public void PressChooseNico()
    {
        SceneManager.LoadScene("Nico");
    }
    public void PressChooseBash()
    {
        SceneManager.LoadScene("Bash");
    }
    public void PressBackToChoosePlayer()
    {
        SceneManager.LoadScene("chooseplayer");
    }
    public void PressProceed()
    {
        SceneManager.LoadScene("house");
    }
    public void PressProceed2()
    {
        SceneManager.LoadScene("house2");
    }
    public void PressProceed3()
    {
        SceneManager.LoadScene("house3");
    }
    public void PressDoneReading()
    {
        SceneManager.LoadScene("player1");
    }
    public void PressDoneReading2()
    {
        SceneManager.LoadScene("player2");
    }
    public void PressDoneReading3()
    {
        SceneManager.LoadScene("player3");
    }
    public void PressDoneReadingBad()
    {
        SceneManager.LoadScene("death");
    }
    public void PressDoneReadingBad2()
    {
        SceneManager.LoadScene("death2");
    }
    public void PressDoneReadingBad3()
    {
        SceneManager.LoadScene("death3");
    }
    public void PressRespawn()
    {
        SceneManager.LoadScene("player1");
    }
    public void PressRespawn2()
    {
        SceneManager.LoadScene("player2");
    }
    public void PressRespawn3()
    {
        SceneManager.LoadScene("player3");
    }
    public void PressIknowAllIneedToKnow()
    {
        SceneManager.LoadScene("woods");
    }
    public void PressIknowAllIneedToKnow2()
    {
        SceneManager.LoadScene("woods2");
    }
    public void PressIknowAllIneedToKnow3()
    {
        SceneManager.LoadScene("woods3");
    }
}