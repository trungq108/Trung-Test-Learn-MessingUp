using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sender : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        BoxColorEvent e = new BoxColorEvent();
        e.Material = this.GetComponent<MeshRenderer>().material;
        EventManager.Instance.TriggerEvent(e);
        Debug.Log("Sender"); 
    }
}
