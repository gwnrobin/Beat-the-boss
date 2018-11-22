using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missle : IEvent
{
    private float speed = 5f;

    private Vector3 startPos;

    Transform target;

    public void Execute()
    {
        
    }

    public void SetTarget(Transform target)
    {
        this.target = target;
    }

    void InstantiateMissile()
    {
        //Instantiate()
    }
}
