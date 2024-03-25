using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookRotateTest : MonoBehaviour
{
    public Transform target;

    private void Update()
    {
        Vector3 rotate = target.position - transform.position;
        transform.rotation = Quaternion.LookRotation(rotate);
    }
}
