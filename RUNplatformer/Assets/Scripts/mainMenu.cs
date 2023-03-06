using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    public int index;

    private void Update()
    {
        //PlayerPrefs.DeleteAll();
        index = PlayerPrefs.GetInt("indexMap");
    }
    public void Next()
    {
         
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + index);
    }

    public void Next1()
    {
        SceneManager.LoadScene("SampleScene");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name + "SampleScene");
    }
    public void Next2()
    {
        
        
    }
}
