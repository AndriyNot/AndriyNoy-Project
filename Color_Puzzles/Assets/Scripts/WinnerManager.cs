using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WinnerManager : MonoBehaviour
{
    public static int Element;

    private int _fullelement = 16;

    
    public GameObject MyPuzzlePanel;
    public GameObject WinnerPanel;

    public TextMeshProUGUI TextPuzzleNumber;

   

    private void Update()
    {
        TextPuzzleNumber.text = "" + Element;
        if (_fullelement == Element)
        {
            WinnerPanel.SetActive(true);
            MyPuzzlePanel.SetActive(false);
        }
    }

    public static void AddElement()
    {
        Element++;
    }

}
