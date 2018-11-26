using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    public float Mass = 30;
    public float MaxVelocity = 10;
    public float MaxForce = 1;

    private Vector3 velocity = new Vector3(0, 10, -5);
    public Transform target;

    private void Start()
    {
        target = GameObject.Find("PlayerController").transform;
    }

    private void Update()
    {
        var desiredVelocity = target.transform.position - transform.position;
        desiredVelocity = desiredVelocity.normalized * MaxVelocity;

        var steering = desiredVelocity - velocity;
        steering = Vector3.ClampMagnitude(steering, MaxForce);
        steering /= Mass;

        velocity = Vector3.ClampMagnitude(velocity + steering, MaxVelocity);
        transform.position += velocity * Time.deltaTime;
        transform.forward = velocity.normalized;
    }
}