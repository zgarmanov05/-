using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseScript : MonoBehaviour
{
    public Text val;
    public GameObject sphere;
    //public bool start = false;

    bool cond = false;
    float speed = 0;   
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        val.text = "Forse: " + speed.ToString();
    }

    ///

    private void Update()
    {
        PScript dirvector = sphere.GetComponent<PScript>();
        Vector3 mousedir = dirvector.dir;

        if (rb.velocity.magnitude < 0.1f)
        {
            if (Input.GetAxis("Fire1") > 0)
            {
                speed++;
                val.text = "Forse: " + speed.ToString();
            }

            if (Input.GetMouseButtonUp(0) || (speed == 1000))
            {
                rb.AddForce(mousedir * speed);
                cond = true;

            }

            if (cond == true)
            {
                speed = 0;
                val.text = "Forse: " + speed.ToString();
            }


            cond = false;
        }
    }

    // Update is called once per frame
    void LateUpdate()
    {
        
    }
}
