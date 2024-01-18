using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    Vector2 direction;
    public Rigidbody2D rb;
    public float speed = 150f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        direction.x = Input.GetAxis("Horizontal");
        direction.y = Input.GetAxis("Vertical");
    }


    private void FixedUpdate()
    {
        rb.AddForce(direction * speed *Time.deltaTime);
    }
}
