using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float forwardSpeed = 5;
    [SerializeField] private float minLimit;
    [SerializeField] private float maxLimit;
    [SerializeField] private float smoothness;
    private float startX;
    private float lastX;
    private float distance;
    private float movementValue;
    private void Update()
    {
        transform.position += Vector3.forward * forwardSpeed * Time.deltaTime;

        if (Input.GetMouseButtonDown(0))
        {
            startX = Input.mousePosition.x;
        }
        else if (Input.GetMouseButton(0))
        {
            lastX = Input.mousePosition.x;
            distance = lastX - startX;
            movementValue = (distance / Screen.width) * smoothness;
            Swipe(movementValue);
            startX = lastX;
        }
    }

    private void Swipe(float movementValue)
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x + movementValue, minLimit, maxLimit),
            transform.position.y, transform.position.z);
    }
}