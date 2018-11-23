using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissleEvent : MonoBehaviour, IEvent
{
    [SerializeField]
    private GameObject missle;

    public void Execute()
    {
        GameObject missle = Instantiate(this.missle);
    }
}
