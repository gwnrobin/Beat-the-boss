using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FistsSlam : MonoBehaviour
{
    [SerializeField]
    private AnimationClip ani;

    Vector3 offset = new Vector3(0, 5, 0);
    float smoothTime = 0.075f;

    private Transform target;

    private void Start()
    {
        target = GameObject.Find("PlayerController").transform;
        Destroy(this.gameObject, ani.length);
    }

    private void FixedUpdate()
    {
        var distance = (target.position + offset) - transform.position;

        transform.position += (distance * smoothTime);
    }
}
