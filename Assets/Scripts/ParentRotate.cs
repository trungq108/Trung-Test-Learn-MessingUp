using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentRotate : MonoBehaviour
{
    void Update()
    {
        Vector3 rotate = new Vector3(0, 50, 0);
        transform.Rotate(rotate * Time.deltaTime);
    }
}
