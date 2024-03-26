using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicMovement : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float strength;
    float rotX;
    float rotY;
    bool isRotate;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            isRotate = true;
            rotX = Input.GetAxis("Mouse X") * strength;
            rotY = Input.GetAxis("Mouse Y") * strength;
        }
        else { isRotate = false; }
    }

    private void FixedUpdate()
    {
        if(isRotate)
        {
            rb.AddTorque(rotY, -rotX, 0);
        }
    }
}
