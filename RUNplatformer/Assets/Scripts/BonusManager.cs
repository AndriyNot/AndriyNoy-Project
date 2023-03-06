using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusManager : MonoBehaviour
{
    public int index;
    private void Awake()
    {
        index = PlayerPrefs.GetInt("bonus");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("user"))
        {
            index = 1;
            PlayerPrefs.SetInt("bonus", index);
            Destroy(gameObject);
        }
    }



}
