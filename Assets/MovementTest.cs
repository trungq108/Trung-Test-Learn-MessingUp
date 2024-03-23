using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementTest : MonoBehaviour
{
    public float speed = 2f;

    private void Update()
    {
       
    }

    void Move()
    {
        transform.position += transform.up * speed * Time.deltaTime;
    }
}
