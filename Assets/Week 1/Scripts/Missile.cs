using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;

public class Missile : MonoBehaviour
{
    public float speed = 10;
    
    public Transform barrel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(transform.position.x * speed * Time.deltaTime,0,0);

        }
    }
}
