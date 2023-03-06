using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject[] Players;
    public GameObject[] Button;
    public int indexCharacter;
    public int indexPlayer1;
    private void Awake()
    {
        

    }
    private void Update()
    {
        
        indexCharacter = PlayerPrefs.GetInt("indexCharacter");
        indexPlayer1 = PlayerPrefs.GetInt("block1");
        selectionCharacters();
        SelectionButton();
    }
    public void selectionCharacters()
    {
        if (indexCharacter == 1)
        {
            Players[0].SetActive(true);
            Players[1].SetActive(false);
            Players[2].SetActive(false);
            Players[3].SetActive(false);
            Players[4].SetActive(false);
            Players[5].SetActive(false);
            Players[6].SetActive(false);

        }
        if (indexCharacter == 2 )
        {
            Players[0].SetActive(false);
            Players[1].SetActive(true);
            Players[2].SetActive(false);
            Players[3].SetActive(false);
            Players[4].SetActive(false);
            Players[5].SetActive(false);
            Players[6].SetActive(false);
        }
        if (indexCharacter == 3)
        {
            Players[0].SetActive(false);
            Players[1].SetActive(false);
            Players[2].SetActive(true);
            Players[3].SetActive(false);
            Players[4].SetActive(false);
            Players[5].SetActive(false);
            Players[6].SetActive(false);
        }
        if (indexCharacter == 4)
        {
            Players[0].SetActive(false);
            Players[1].SetActive(false);
            Players[2].SetActive(false);
            Players[3].SetActive(true);
            Players[4].SetActive(false);
            Players[5].SetActive(false);
            Players[6].SetActive(false);
        }
        if (indexCharacter == 5)
        {
            Players[0].SetActive(false);
            Players[1].SetActive(false);
            Players[2].SetActive(false);
            Players[3].SetActive(false);
            Players[4].SetActive(true);
            Players[5].SetActive(false);
            Players[6].SetActive(false);
        }
        if (indexCharacter == 6)
        {
            Players[0].SetActive(false);
            Players[1].SetActive(false);
            Players[2].SetActive(false);
            Players[3].SetActive(false);
            Players[4].SetActive(false);
            Players[5].SetActive(true);
            Players[6].SetActive(false);
        }
        if (indexCharacter == 7)
        {
            Players[0].SetActive(false);
            Players[1].SetActive(false);
            Players[2].SetActive(false);
            Players[3].SetActive(false);
            Players[4].SetActive(false);
            Players[5].SetActive(false);
            Players[6].SetActive(true);

        }

    }

    public void SelectionButton()
    {
        if (indexCharacter == 1)
        {
            Button[0].SetActive(true);
            Button[1].SetActive(false);
            Button[2].SetActive(false);
            Button[3].SetActive(false);
            Button[4].SetActive(false);
            Button[5].SetActive(false);
            Button[6].SetActive(false);

        }
        if (indexCharacter == 2)
        {
            Button[0].SetActive(false);
            Button[1].SetActive(true);
            Button[2].SetActive(false);
            Button[3].SetActive(false);
            Button[4].SetActive(false);
            Button[5].SetActive(false);
            Button[6].SetActive(false);

        }
        if (indexCharacter == 3)
        {
            Button[0].SetActive(false);
            Button[1].SetActive(false);
            Button[2].SetActive(true);
            Button[3].SetActive(false);
            Button[4].SetActive(false);
            Button[5].SetActive(false);
            Button[6].SetActive(false);
        }
        if (indexCharacter == 4)
        {
                Button[0].SetActive(false);
                Button[1].SetActive(false);
                Button[2].SetActive(false);
                Button[3].SetActive(true);
                Button[4].SetActive(false);
                Button[5].SetActive(false);
                Button[6].SetActive(false);

        }
        if (indexCharacter == 5)
        {
                Button[0].SetActive(false);
                Button[1].SetActive(false);
                Button[2].SetActive(false);
                Button[3].SetActive(false);
                Button[4].SetActive(true);
                Button[5].SetActive(false);
                Button[6].SetActive(false);
        }
        if (indexCharacter == 6)
        {
                Button[0].SetActive(false);
                Button[1].SetActive(false);
                Button[2].SetActive(false);
                Button[3].SetActive(false);
                Button[4].SetActive(false);
                Button[5].SetActive(true);
                Button[6].SetActive(false);
        }
        if (indexCharacter == 7)
        {
            Button[0].SetActive(false);
            Button[1].SetActive(false);
            Button[2].SetActive(false);
            Button[3].SetActive(false);
            Button[4].SetActive(false);
            Button[5].SetActive(false);
            Button[6].SetActive(true);

        }

    }
}
