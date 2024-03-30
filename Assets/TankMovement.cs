using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMovement : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(MyCoroutine());
        }
    }

    IEnumerator MyCoroutine()
    {
        print("Ok here we go!");
        yield return StartCoroutine(MyOtherCoroutine());
        print("Ok we are so DONE !");
    }

    IEnumerator MyOtherCoroutine()
    {
        int i = 5;
        while (i > 0)
        {
            print(i);
            i--;
            yield return new WaitForSeconds(1);
        }
        print("All done BAE :)) ");
    }
}
