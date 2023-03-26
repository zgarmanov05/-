using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDoor : MonoBehaviour
{
    public GameObject door;
    public int speed;

    [HideInInspector]    
    int dir = 1;
    

    void Start()
    {
       
    }    

    // Update is called once per frame
    void FixedUpdate()
    {
        if (transform.position.y >= 6.5f)
        {
            dir = -1;
            speed = speed*2;
        }

        if (transform.position.y <= 0f)
        {
            dir = 1;
            speed = speed/2;
        }


        transform.position += (transform.up * Time.fixedDeltaTime * speed) * dir;

        //Debug.Log(Time.fixedDeltaTime.ToString());
           
    }
}
