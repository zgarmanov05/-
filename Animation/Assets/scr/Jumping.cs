using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumping : MonoBehaviour
{
    public Transform groundDetecter;
    public LayerMask floor;

    Animator anim;
    Rigidbody rb;


    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>(); 
    }

    private void FixedUpdate()
    {
        bool groundChecker = Physics.Raycast(groundDetecter.position, Vector3.down, 0.1f, floor);
        bool falling = !(Physics.Raycast(groundDetecter.position, Vector3.down, 0.3f, floor));
        bool jump = Input.GetKey(KeyCode.Space) && groundChecker;

        if (falling)
            anim.SetBool("isFalling",true);
        else anim.SetBool("isFalling", false);

        if (jump)
        {
            rb.AddForce(Vector3.up * 1500);
            anim.SetBool("isJumping", true);
        }
        else
        { 
            anim.SetBool("isJumping", false);
        }
    }
}
