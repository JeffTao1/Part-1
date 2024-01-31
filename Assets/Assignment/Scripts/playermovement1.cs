using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement1 : MonoBehaviour
{
    public float speed;
    public float where;
    public float jump = 10;
    public Rigidbody2D rb; // use for the jump
    bool Jumpy;//to check was jumped or not 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        where = Input.GetAxis("Horizontal");//the player will go left or right follow the x line
        transform.Translate(where * speed * Time.deltaTime, 0, 0);// and this is a vector3 so I only use X one and give the x a direction to go and times the speed then make sure is go every flame so add Time.sltaTime

        if (Input.GetKeyDown(KeyCode.Space) && Jumpy)//after pressed the space the player will jump
        {
           rb.AddForce(new Vector2(0,jump),ForceMode2D.Impulse);//use AddForce to make the RB2 go up that make the jump work; math.
            Jumpy = false;//after it jump make the player can't jump again
            
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) // if the player's collied tunch on the stage then can jump again
    {
        Jumpy = true;
        
    }
    private void OnTriggerEnter2D(Collider2D collision)// if the player tunch on the triggered dieline or winline player destroy  
    {
        Destroy(gameObject);
    }



}
