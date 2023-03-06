using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransparentBonus : MonoBehaviour
{
    private int _index;
    private float _timer;
    public BoxCollider2D colliders;

    void Update()
    {
        colliders = GetComponent<BoxCollider2D>();
        _index = PlayerPrefs.GetInt("bonus");

        if (_index == 1)
        {
            colliders.isTrigger = true;
            _timer += Time.deltaTime;
            if (_timer >= 5 && _index == 1)
            {
                colliders.isTrigger = false;
                _timer = 0;
                _index = 0;
                PlayerPrefs.SetInt("bonus", _index);
            }
        }
        if (_index == 0)
        {
            _timer = 0;
        }


    }
}
