using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTest : MonoBehaviour
{
    public GameObject objectToOrbit;
    Vector3 direction;
    float angle;
    float radius;
    public float degreesPerSecond = 10;

    private void Start()
    {
        direction = (transform.position - objectToOrbit.transform.position).normalized;
        radius = Vector3.Distance(objectToOrbit.transform.position, transform.position);
    }

    private void Update()
    {
        angle += degreesPerSecond * Time.deltaTime;

        if (angle > 360)
        {
            angle -= 360;
        }

        Vector3 orbit = Vector3.forward * radius;
        orbit = Quaternion.LookRotation(direction) * Quaternion.Euler(0, angle, 0) * orbit;

        transform.position = objectToOrbit.transform.position + orbit;
    }
}