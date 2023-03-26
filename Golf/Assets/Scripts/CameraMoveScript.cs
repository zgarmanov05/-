using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoveScript : MonoBehaviour
{
    // Start is called before the first frame update

    public float movespeed = 10;
    public float anglespeed = 10;
    public Camera cum;

    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float vert = Input.GetAxisRaw("Vertical");
        float hor = Input.GetAxisRaw("Horizontal");

        Vector3 dir = new Vector3(hor, 0, vert);
        dir.Normalize();

        dir = transform.TransformDirection(dir) * Time.fixedDeltaTime * movespeed;

        cum.transform.position += dir;

        if(Input.GetKey(KeyCode.Q) == true)
        {
            cum.transform.Rotate(new Vector3(0, 1, 0), -anglespeed * Time.fixedDeltaTime, Space.Self);
        }

        if (Input.GetKey(KeyCode.E) == true)
        {
            cum.transform.Rotate(new Vector3(0, 1, 0), anglespeed * Time.fixedDeltaTime, Space.Self);
        }

        if (Input.GetKey(KeyCode.Z) == true)
        {
            cum.transform.Rotate(new Vector3(1, 0, 0), anglespeed * Time.fixedDeltaTime, Space.Self);
        }

        if (Input.GetKey(KeyCode.X) == true)
        {
            cum.transform.Rotate(new Vector3(1, 0, 0), -anglespeed * Time.fixedDeltaTime, Space.Self);
        }

    }
}
