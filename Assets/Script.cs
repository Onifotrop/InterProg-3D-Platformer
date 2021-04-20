using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Script : MonoBehaviour
{
    public Rigidbody rb;

    public float turnSpeed;

    public float speed;

    private float rotate;

    private float forward;
    
    private float jump;
    
    private  float gravityScale = -9.8f;

    public GameObject noJump;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        turnSpeed = 10;
        speed = 50;
        
    }

    // Update is called once per frame

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + (transform.forward * speed *forward * Time.deltaTime));
        rb.MoveRotation(Quaternion.AngleAxis(rotate * turnSpeed, Vector3.up) * rb.rotation);
        rb.AddForce(Vector3.up*jump*500);
        rb.AddForce(new Vector3(0,gravityScale,0), ForceMode.Acceleration);
        
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            rb.velocity = Vector3.zero;
            this.transform.position = new Vector3(0, 15, 65);
        }
        rotate = Input.GetAxis("Horizontal");
        forward = Input.GetAxis("Vertical");
        //jump = Input.GetAxis("Jump");
        if (Input.GetKey(KeyCode.Space))
        {
            noJump.SetActive(true);
        }
        
    }

    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Fire")
        {
            rb.velocity = Vector3.zero;
            this.transform.position = new Vector3(0, 15, 65);
        }
    }
}
