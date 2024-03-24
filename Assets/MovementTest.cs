using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementTest : MonoBehaviour
{
    [SerializeField] float t;

    private void Update()
    {
        float lept = Mathf.Lerp(0, 3000, t);
        Debug.Log(lept);
    }
}
