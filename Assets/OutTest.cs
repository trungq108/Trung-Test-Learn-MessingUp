using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutTest : MonoBehaviour
{
    public string numResult;

    private void Start()
    {
        bool result = IsAboveTen(20,out numResult);
        Debug.Log(numResult);
    }

    bool IsAboveTen(float num, out string result)
    {
        if (num > 10)
        {
            result = "The number was more than 10!";
            return true;
        }
        else
        {
            result = "The number was not more than 10!";
            return false;
        }
    }
}
