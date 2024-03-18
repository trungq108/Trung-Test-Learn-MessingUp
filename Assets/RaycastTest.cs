using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using UnityEngine;

public class RaycastTest : MonoBehaviour
{
    RaycastHit[] hits;

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            FireRay();
        }
    }

    void FireRay()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(ray.origin, ray.direction * 20, Color.red);

        hits = Physics.RaycastAll(ray);

        foreach(RaycastHit hit in hits)
        {
            Destroy(hit.collider.gameObject);
        }
    }
}
