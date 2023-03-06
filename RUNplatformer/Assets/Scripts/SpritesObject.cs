using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpritesObject : MonoBehaviour
{
    public Image logo;
    public Sprite[] sprite;
    public int index;
    public int indexer;

    void Start()
    {
        logo = GetComponent<Image>();
        
       
       
    }

   

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Imag")
        {
            logo.sprite = sprite[0];
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Imag")
        {
            logo.sprite = sprite[0];
        }
    }
    private void Update()
    {
        
    }
}
