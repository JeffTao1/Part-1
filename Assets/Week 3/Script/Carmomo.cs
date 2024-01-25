using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carmomo : MonoBehaviour
{
    public float acceleration;
    public float steering;
    public float forwardspeed = 500;
    public float steeringspeed = 200;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();   
    }

    // Update is called once per frame
    void Update()
    {
        acceleration = Input.GetAxis("Vertical");
        steering = Input.GetAxis("Horizontal");
    }


    private void FixedUpdate()
    {
        rb.AddTorque(steering * -steeringspeed * Time.deltaTime);
        Vector2 force = transform.up * acceleration * forwardspeed * Time.deltaTime;
        rb.AddForce(force);
    }
}
