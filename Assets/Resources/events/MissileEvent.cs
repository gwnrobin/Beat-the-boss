using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileEvent : MonoBehaviour, IEvent
{
    [SerializeField]
    private GameObject missile;

    void Start()
    {
        missile = Resources.Load("Assets/Prefabs/Missle") as GameObject;
    }

    public void Execute()
    {
        GameObject missile = Instantiate(this.missile);
    }
}
