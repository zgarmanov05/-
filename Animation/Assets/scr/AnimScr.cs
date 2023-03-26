using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimScr : MonoBehaviour
{
    Animator anim;
    Rigidbody rb;
    public Camera cam;
    public float speedMovment;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Vertical") > 0)
        {
            {
                anim.SetInteger("state", 1);
                transform.Translate(Vector3.forward * Time.deltaTime*speedMovment);  
            }
            if (Input.GetKey(KeyCode.LeftShift))
            { 
                anim.SetInteger("state", 2); 
                transform.Translate(Vector3.forward * Time.deltaTime * speedMovment*12); 
            }
           
        }
        else
            anim.SetInteger("state", 0);
        if (Input.GetKey(KeyCode.D))
            transform.Rotate(Vector3.up, 90 * Time.deltaTime, Space.Self);
        if (Input.GetKey(KeyCode.A))
            transform.Rotate(-(Vector3.up), 90 * Time.deltaTime, Space.Self);

        if (Input.GetMouseButton(0))
        { 
            anim.SetTrigger("isAttack");    
        }
    }
    
}
