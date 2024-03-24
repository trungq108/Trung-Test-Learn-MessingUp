using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicMovement : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float speed;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        Vector3 moveAxis = new Vector3 (Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        moveAxis = Vector3.ClampMagnitude(moveAxis, 1);

        rb.MovePosition(rb.position + moveAxis * speed * Time.fixedDeltaTime);
    }
}
