using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using UnityEngine;

public class RaycastTest : MonoBehaviour
{
 
    void Update()
    {
        FireRay();
    }

    void FireRay()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
      //  Debug.DrawRay(ray.origin, ray.direction * 20, Color.red);

        RaycastHit hitData;

        if(Physics.Raycast(ray, out hitData))
        {
            
        }
    }
}
