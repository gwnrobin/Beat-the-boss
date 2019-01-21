using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothCamera : MonoBehaviour
{
    public Transform target;
    public Vector3 offset = new Vector3(0, 5, -10);
    public float smoothTime = 0.01f;

    private void FixedUpdate()
    {
        var distance = (target.position + offset) - transform.position;

        transform.position += (distance * smoothTime);
    }
}
