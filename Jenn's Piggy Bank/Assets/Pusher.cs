using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pusher : MonoBehaviour
{
    [SerializeField] [Range(0f, 10f)] float oscillationPeriod = 2f;
    [SerializeField] float movementFactor;
    [SerializeField] Vector3 movementVector;
    [SerializeField] Rigidbody body;
    Vector3 startingPoint;

    private void Start()
    {

        startingPoint = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        var offset = movementFactor * movementVector;
        body.transform.position = startingPoint + offset;
        var tau = Mathf.PI * 2;
        var currentGameTime = Time.time;
        var cycles = currentGameTime / oscillationPeriod;
        movementFactor = Mathf.Sin(cycles * tau) / 2f + 0.5f;

    }
}
