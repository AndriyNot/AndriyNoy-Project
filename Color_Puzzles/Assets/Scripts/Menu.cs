using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void OnButtonRestartLevel1()
    {
        SceneManager.LoadScene("Level1");
        WinnerManager.Element = 0;
    }
    public void OnButtonRestartLevel2()
    {
        SceneManager.LoadScene("Level2");
        WinnerManager.Element = 0;
    }
    public void OnButtonLevel1()
    {
        SceneManager.LoadScene("Level1");
        WinnerManager.Element = 0;
    }
    public void OnButtonLevel2()
    {
        SceneManager.LoadScene("Level2");
        WinnerManager.Element = 0;
    }
    public void OnButtonHome()
    {
        SceneManager.LoadScene("menu");
    }
}
