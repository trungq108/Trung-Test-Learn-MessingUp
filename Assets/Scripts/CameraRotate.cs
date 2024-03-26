using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotate : MonoBehaviour
{
    public float lookSpeed = 0.5f;
    Vector3 look;

    private void Update()
    {
        look += new Vector3(-Input.GetAxis("Mouse Y") * lookSpeed, Input.GetAxis("Mouse X") * lookSpeed, 0);
        look.x = Mathf.Clamp(look.x, -80, 80);
        
        transform.eulerAngles = look;
    }
}
