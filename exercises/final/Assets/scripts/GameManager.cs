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
}
