using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinManager : MonoBehaviour
{
    public int _indexcoins;
    public TextMeshProUGUI Textcoins;
    private int _randoms;

    private void Update()
    {
        _indexcoins = PlayerPrefs.GetInt("coinss");
        Textcoins.text = "" + _indexcoins;

       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("user"))
        {
            _randoms = Random.Range(1, 15);
            _indexcoins += _randoms;
            PlayerPrefs.SetInt("coinss", _indexcoins);
            Destroy(gameObject);
        }
    }
}
