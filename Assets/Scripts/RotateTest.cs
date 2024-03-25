using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTest : MonoBehaviour
{
    float rotateAmount;

    void Update()
    {
        RotateToDegree();
    }

    void RotateToDegree()
    {
        rotateAmount += 20;
        transform.localEulerAngles = new Vector3(0, rotateAmount, 0);
    }
}
;