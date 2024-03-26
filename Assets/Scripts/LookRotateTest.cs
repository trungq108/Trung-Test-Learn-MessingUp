using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookRotateTest : MonoBehaviour
{
    public Transform target;
    public float duration = 5.0f;
    bool isRotate;

    private void Update()
    {
        if(Input.GetMouseButtonDown(0) & !isRotate)
        {
            StartCoroutine(LerpRotate());
        }
    }

    IEnumerator LerpRotate()
    {
        float timeElapse = 0;
        isRotate = true;
        Quaternion startRotation = transform.rotation;
        Quaternion endRotation = Quaternion.LookRotation(target.position - transform.position);

        while (timeElapse < duration)
        {
            transform.rotation = Quaternion.Slerp(startRotation, endRotation, timeElapse / duration);
            timeElapse += Time.deltaTime;
            yield return null;
        }
        transform.rotation = endRotation;
        isRotate = false;
    }
}
