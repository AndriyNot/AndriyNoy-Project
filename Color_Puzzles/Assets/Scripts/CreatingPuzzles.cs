using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CreatingPuzzles : MonoBehaviour
{
    public GameObject[] ObjectsPuzzles;
    public GameObject[] fonPuzzles;
    public GameObject[] ObjectsPuzzlesPoint;
    private int _indexpuzzle = 16;
    private int rand;
    private int indexPuzzlePoint;
    private bool index = false;
    public TextMeshProUGUI TextnumberPuzzles;

    private void Awake()
    {
        rand = Random.Range(0, ObjectsPuzzles.Length);
        ObjectsPuzzles[rand].SetActive(true);
        for (int i = 0; i < ObjectsPuzzles.Length; i++)
        {
            if (rand == i)
            {
                index = true;
                indexPuzzlePoint = i;
                Destroy(fonPuzzles[i]);
                _indexpuzzle -= 1;
                WinnerManager.AddElement();
            }
        }

        


    }
    private void Update()
    {
        TextnumberPuzzles.text = "" + _indexpuzzle;

        if (index == true)
        {
            ObjectsPuzzles[rand].transform.position = ObjectsPuzzlesPoint[indexPuzzlePoint].transform.position;
        }
    }
    public void buttonPuzzle1()
    {
        ObjectsPuzzles[0].SetActive(true);
        Destroy(fonPuzzles[0]);
        _indexpuzzle -= 1;
    }
    public void buttonPuzzle2()
    {
        ObjectsPuzzles[1].SetActive(true);
        Destroy(fonPuzzles[1]);
        _indexpuzzle -= 1;
    }
    public void buttonPuzzle3()
    {
        ObjectsPuzzles[2].SetActive(true);
        Destroy(fonPuzzles[2]);
        _indexpuzzle -= 1;
    }
    public void buttonPuzzle4()
    {
        ObjectsPuzzles[3].SetActive(true);
        Destroy(fonPuzzles[3]);
        _indexpuzzle -= 1;
    }
    public void buttonPuzzle5()
    {
        ObjectsPuzzles[4].SetActive(true);
        Destroy(fonPuzzles[4]);
        _indexpuzzle -= 1;
    }
    public void buttonPuzzle6()
    {
        ObjectsPuzzles[5].SetActive(true);
        Destroy(fonPuzzles[5]);
        _indexpuzzle -= 1;
    }
    public void buttonPuzzle7()
    {
        ObjectsPuzzles[6].SetActive(true);
        Destroy(fonPuzzles[6]);
        _indexpuzzle -= 1;
    }
    public void buttonPuzzle8()
    {
        ObjectsPuzzles[7].SetActive(true);
        Destroy(fonPuzzles[7]);
        _indexpuzzle -= 1;
    }
    public void buttonPuzzle9()
    {
        ObjectsPuzzles[8].SetActive(true);
        Destroy(fonPuzzles[8]);
        _indexpuzzle -= 1;
    }
    public void buttonPuzzle10()
    {
        ObjectsPuzzles[9].SetActive(true);
        Destroy(fonPuzzles[9]);
        _indexpuzzle -= 1;
    }
    public void buttonPuzzle11()
    {
        ObjectsPuzzles[10].SetActive(true);
        Destroy(fonPuzzles[10]);
        _indexpuzzle -= 1;
    }
    public void buttonPuzzle12()
    {
        ObjectsPuzzles[11].SetActive(true);
        Destroy(fonPuzzles[11]);
        _indexpuzzle -= 1;
    }
    public void buttonPuzzle13()
    {
        ObjectsPuzzles[12].SetActive(true);
        Destroy(fonPuzzles[12]);
        _indexpuzzle -= 1;
    }
    public void buttonPuzzle14()
    {
        ObjectsPuzzles[13].SetActive(true);
        Destroy(fonPuzzles[13]);
        _indexpuzzle -= 1;
    }
    public void buttonPuzzle15()
    {
        ObjectsPuzzles[14].SetActive(true);
        Destroy(fonPuzzles[14]);
        _indexpuzzle -= 1;
    }
    public void buttonPuzzle16()
    {
        ObjectsPuzzles[15].SetActive(true);
        Destroy(fonPuzzles[15]);
        _indexpuzzle -= 1;
    }

    
}
