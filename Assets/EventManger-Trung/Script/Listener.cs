using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Listener : MonoBehaviour
{
    private void OnEnable()
    {
        EventManager.AddListener<BoxColorEvent>(ColorHandler);
    }

    private void OnDisable()
    {
        EventManager.RemoveListener<BoxColorEvent>(ColorHandler);
    }

    private void ColorHandler(BoxColorEvent e)
    {
        Debug.Log("Listener");
        gameObject.GetComponent<MeshRenderer>().material = e.Material;
    }
}
