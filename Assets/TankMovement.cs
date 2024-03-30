using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMovement : MonoBehaviour
{
    WaitForSeconds delay = new WaitForSeconds(1);

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartCoroutine(Move());
        }
    }

    IEnumerator Move()
    {
        print("Start waiting");

        yield return new WaitForSeconds(1);

        print("5 seconds has passed");
    }
}
