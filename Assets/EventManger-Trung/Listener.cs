using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Listener : MonoBehaviour
{
    private void OnEnable()
    {
        EventManager.Instance.AddListener<BoxColorEvent>(ColorHandler);
    }

    private void OnDisable()
    {
        EventManager.Instance.RemoveListener<BoxColorEvent>(ColorHandler);
    }

    private void ColorHandler(BoxColorEvent e)
    {
        Debug.Log("Listener");
        gameObject.GetComponent<MeshRenderer>().material = e.Material;
    }
}
