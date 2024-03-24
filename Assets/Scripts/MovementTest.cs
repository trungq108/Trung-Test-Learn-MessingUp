using System;
using System.Collections;
using UnityEngine;

public class MovementTest : MonoBehaviour
{
    bool isOpen;
    Vector3 closedPosition;
    public float openHeight = 4.5f;

    private void Start()
    {
        closedPosition = transform.position;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Movement();
        }
    }

    void Movement()
    {
        StopAllCoroutines();

        if(isOpen)
        {
            StartCoroutine(DoorMovement(closedPosition));
        }

        else
        {
            Vector3 openPosition = closedPosition + Vector3.up * openHeight;
            StartCoroutine(DoorMovement(openPosition));
        }
        isOpen = !isOpen;
    }

    IEnumerator DoorMovement(Vector3 endPosition)
    {
        float timeElape = 0f;
        float duration = 1f;

        Vector3 startPosition = transform.position;

        while(timeElape < duration)
        {
            transform.position = Vector3.Lerp(startPosition, endPosition, timeElape/duration);
            timeElape += Time.deltaTime;
            yield return new WaitForEndOfFrame();
        }
        transform.position = endPosition;
    }
}
