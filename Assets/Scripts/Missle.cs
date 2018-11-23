using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missle : MonoBehaviour
{
    private Rigidbody rb;

    private float speed;
    private float steerForce;

    private Vector3 checkPoint = new Vector3(0, 5, 0);

    private Vector3 desiredVelocity;

    private Vector3 currentPosition;

    private Vector3 target;

    public void Start()
    {
        rb = GetComponent<Rigidbody>();
        target = GameObject.Find("PlayerController").transform.position;

        desiredVelocity = target - transform.position;

        rb.velocity = new Vector3(1, 1, 0);
    }

    void Update()
    {

        currentPosition += velocity;

        transform.position = currentPosition;
        transform.rotation = Quaternion.LookRotation(velocity);
    }
}
