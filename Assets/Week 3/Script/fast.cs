using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fast : MonoBehaviour
{
    public float speed;
    public GameObject go;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) { 
            go.gameObject.SetActive(false);
            Transform.Destroy(go);
        
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

        collision.rigidbody.AddForce(new Vector2(Random.Range(-90, 90), Random.Range(-90, 180) * speed * Time.deltaTime));
       

    }
}
