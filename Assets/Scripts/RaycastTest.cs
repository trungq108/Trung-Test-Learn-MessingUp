using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using UnityEngine;
using System;

public class RaycastTest : MonoBehaviour
{
    Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Ray ray = new Ray(transform.position, Vector3.down);
        Debug.DrawRay(ray.origin, ray.direction * 5, Color.yellow);

        if(Physics.Raycast(ray, 5))
        {
            FloatUp();
        }
    }

    void FloatUp()
    {
        rb.AddForce(Vector3.up * 20);
    }
}
