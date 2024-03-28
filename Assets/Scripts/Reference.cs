using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reference : MonoBehaviour
{
    GameObject[] enemies;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            DestroyTest();
        }
    }

    void DestroyTest()
    {
        enemies = GameObject.FindGameObjectsWithTag("Enemy");
        for(int i = 0; i < enemies.Length; i++)
        {
            enemies[i].SetActive(false);
        }
    }
}
