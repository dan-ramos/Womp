using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class WompGravity : MonoBehaviour
{
    // gravity scale able to change in unity
    public float gScale = 1.0f;

    Rigidbody rb;

    void Start()
    {
        // receives rigid body script is placed on
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
    }

    void FixedUpdate()
    {
        // constantly applies gravity force to rb (womp)
        rb.AddForce(Physics.gravity * gScale, ForceMode.Acceleration);
    }
}
