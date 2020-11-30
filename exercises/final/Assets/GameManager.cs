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
    public void PressMiko()
    {
        SceneManager.LoadScene("openingscene");
    }
    public void PressSuki()
    {
        SceneManager.LoadScene("openingscene");
    }
    public void PressNext()
    {
        SceneManager.LoadScene("openingscene2");
    }
    public void PressNext2()
    {
        SceneManager.LoadScene("openingscene1");
    }
    public void PressNext3()
    {
        SceneManager.LoadScene("openingscenelast");
    }
    public void PressNext4()
    {
        SceneManager.LoadScene("openingscene3");
    }
    public void PressNextMiko()
    {
        SceneManager.LoadScene("playsceneMiko");
    }
    public void PressNextSuki()
    {
        SceneManager.LoadScene("playsceneSuki");
    }
}
