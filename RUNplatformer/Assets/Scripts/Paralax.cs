using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paralax : MonoBehaviour
{
    
    public GameObject mountain;
    public GameObject cloud;
    public Vector2 VectorMountain;
    public Vector2 VectorCloud;






    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Mountain"))
        {
            Instantiate(mountain, VectorMountain, Quaternion.Euler(0, 0, 0));
            Instantiate(cloud, VectorCloud, Quaternion.Euler(0, 0, 0));
        }
    }
}
