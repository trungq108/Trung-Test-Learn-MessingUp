using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotate : MonoBehaviour
{
    public Transform player;

    private void Update()
    {
        transform.LookAt(Input.mousePosition);
    }
}
