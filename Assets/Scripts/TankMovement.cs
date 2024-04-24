using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMovement : MonoBehaviour
{
    [SerializeField] PlayerData playerData;
    private void Update()
    {
        playerData.currentPosition = transform.position;
    }
}
