using System.Collections;
using System.Collections.Generic;
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
    public void PressInstructions()
    {
        SceneManager.LoadScene("instructions");
    }
    public void PressGoBack()
    {
        SceneManager.LoadScene("titlescreen");
    }
    public void PressSoundtrack()
    {
        SceneManager.LoadScene("soundtrack");
    }
    public void PressHome()
    {
        SceneManager.LoadScene("titlescreen");
    }
    public void PressMiko()
    {
        SceneManager.LoadScene("openingsceneMIKO");
    }
    public void PressSuki()
    {
        SceneManager.LoadScene("openingsceneSUKI");
    }
    public void PressNextMIKO()
    {
        SceneManager.LoadScene("openingscene2MIKO");
    }
    public void PressNext2MIKO()
    {
        SceneManager.LoadScene("openingscene3MIKO");
    }
    public void PressNextSUKI()
    {
        SceneManager.LoadScene("openingscene2SUKI");
    }
    public void PressNext2SUKI()
    {
        SceneManager.LoadScene("openingscene3SUKI");
    }
    public void PressPlayMIKO()
    {
        SceneManager.LoadScene("playsceneMiko");
    }
    public void PressPlaySUKI()
    {
        SceneManager.LoadScene("playsceneSuki");
    }
    public void PressRetryMIKO()
    {
        SceneManager.LoadScene("openingscene3MIKO");
    }
    public void PressRetrySUKI()
    {
        SceneManager.LoadScene("openingscene3SUKI");
    }
    public void PressLoseMIKO()
    {
        SceneManager.LoadScene("MIKOLOSES");
    }
    public void PressLoseSUKI()
    {
        SceneManager.LoadScene("SUKILOSES");
    }
    public void PressResetMIKO()
    {
        SceneManager.LoadScene("playsceneMiko");
    }
    public void PressResetSUKI()
    {
        SceneManager.LoadScene("playsceneSuki");
    }
    public void PressContinueMIKOLOSES()
    {
        SceneManager.LoadScene("scoreMIKOLOSES2");
    }
    public void PressContinueSUKILOSES()
    {
        SceneManager.LoadScene("scoreSUKILOSES2");
    }
    public void PressTheEndMIKOLOSES()
    {
        SceneManager.LoadScene("MIKOLOSES2");
    }
    public void PressTheEndSUKILOSES()
    {
        SceneManager.LoadScene("SUKILOSES2");
    }
    public void PressContinueMIKOWINS()
    {
        SceneManager.LoadScene("scoreMIKOWINS2");
    }
    public void PressContinueSUKIWINS()
    {
        SceneManager.LoadScene("scoreSUKIWINS2");
    }
    public void PressTheEndMIKOWINS()
    {
        SceneManager.LoadScene("MIKOWINS");
    }
    public void PressTheEndSUKIWINS()
    {
        SceneManager.LoadScene("SUKIWINS");
    }
    public void PressHelp()
    {
        SceneManager.LoadScene("Help");
    }
    public void PressHelp2()
    {
        SceneManager.LoadScene("Help2");
    }
    public void PressBackfromHelp()
    {
        SceneManager.LoadScene("playsceneMiko");
    }
    public void PressBackfromHelp2()
    {
        SceneManager.LoadScene("playsceneSuki");
    }
}
