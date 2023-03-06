using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
   
   

    public void ButtonPause()
    {
        Time.timeScale = 0;
    }
    public void ButtonPlay()
    {
        Time.timeScale = 1;
    }

    public void MenuCharacter()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
