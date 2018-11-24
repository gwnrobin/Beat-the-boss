using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missle : MonoBehaviour
{
    private Rigidbody rb;

    private float speed = 5f;
    private float steerForce;

    private Vector3 checkPoint = new Vector3(0, 10, 0);

    private Vector3 desiredVelocity;

    private Vector3 currentPosition;

    private Vector3 target;

    public void Start()
    {
        rb = GetComponent<Rigidbody>();
        target = GameObject.Find("PlayerController").transform.position;

        desiredVelocity = target - transform.position;

        desiredVelocity = desiredVelocity.normalized * speed;

        rb.velocity = new Vector3(0, 1 * speed, 0);
    }

    void Update()
    {
        if(transform.position != target)
        rb.velocity += desiredVelocity;
    }
}
