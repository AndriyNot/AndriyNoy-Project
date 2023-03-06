using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    public int speed = 5;
   
    void Update()
    {
     
        transform.Translate(new Vector3(-1, 0, 0) * speed * Time.deltaTime);
        float posx = transform.position.x;

        if (posx <= -26)
        {
            Destroy(gameObject);
        }

    }
    
}
