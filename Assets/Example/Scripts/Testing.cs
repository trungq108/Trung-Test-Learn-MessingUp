using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Lean.Pool;

public class Testing : MonoBehaviour
{
    [SerializeField] GameObject cubePrefab;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Box cube = LeanPool.Spawn(cubePrefab, this.transform.position, Quaternion.identity, null).GetComponent<Box>();
            LeanPool.Despawn(cube, 3f);
        }
    }
}
