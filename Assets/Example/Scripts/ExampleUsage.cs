using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleUsage : MonoBehaviour
{
    public ObjectPoolManager objectPoolManager;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject obj = objectPoolManager.Get();
            obj.transform.position = transform.position;
            StartCoroutine(ReleaseObject(obj, 2f));
        }
    }

    private IEnumerator ReleaseObject(GameObject obj, float delay)
    {
        yield return new WaitForSeconds(delay);
        objectPoolManager.Release(obj);
    }
}
