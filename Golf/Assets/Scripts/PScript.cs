using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PScript : MonoBehaviour
{
    public Camera cum;

    public LayerMask floor;

    public Vector3 dir;
    Rigidbody rb;
    LineRenderer lr;
    public GameObject flor;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        lr = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        RaycastHit hit;
        Ray ray = cum.ScreenPointToRay(Input.mousePosition);

        lr.SetPosition(0, transform.position);
        lr.SetPosition(1, transform.position);
        if(rb.velocity.magnitude<0.1f)
        {
        if (Physics.Raycast(ray, out hit, 1000, floor))
        {
            Vector3 pnt = hit.point;
            pnt.y = transform.position.y;

            dir = (pnt - transform.position);
            dir.Normalize();
            dir *= 2;

            lr.SetPosition(1, (transform.position + dir));
        }
        }
        else
        {
            lr.SetPosition(1, transform.position);
        }

        flor.transform.position = transform.position;
    }
}
