using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mass : MonoBehaviour
{
    private Rigidbody rb;
    public Vector3 newMass;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        rb.centerOfMass = newMass;
        Debug.Log(rb.centerOfMass);
    }
}
