using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingWalls : MonoBehaviour
{
    [SerializeField] private Transform startPoint;
    [SerializeField] private Transform endPoint;
    [SerializeField] private float speed = 2.0f;

    private Vector3 currentTarget;

    private void Start()
    {
        // Initialize the current target to be the endpoint, so the platform starts at the end.
        currentTarget = endPoint.position;
    }

    private void Update()
    {
        // Move the platform towards the current target position.
        transform.position = Vector3.MoveTowards(transform.position, currentTarget, speed * Time.deltaTime);

        // Check if the platform has reached the current target position.
        if (Vector3.Distance(transform.position, currentTarget) < 0.1f)
        {
            // If the platform is at the endpoint, switch the current target to the start point.
            // If it's at the start point, switch the current target to the endpoint.
            currentTarget = (currentTarget == endPoint.position) ? startPoint.position : endPoint.position;
        }
    }
}
