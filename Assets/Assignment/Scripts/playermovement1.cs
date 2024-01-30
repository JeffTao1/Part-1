using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement1 : MonoBehaviour
{
    public float speed;
    public float where;
    public float jump = 10;
    public Rigidbody2D rb;
    bool Jumpy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        where = Input.GetAxis("Horizontal");
        transform.Translate(where * speed * Time.deltaTime, 0, 0);

        if (Input.GetKeyDown(KeyCode.Space) && Jumpy)
        {
           rb.AddForce(new Vector2(0,jump),ForceMode2D.Impulse);
            Jumpy = false;
            
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Jumpy = true;
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
    }



}
