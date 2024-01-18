using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swich : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    public Color mC;
    // Start is called before the first frame update
    void Start()
    {
         spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = mC;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Trigger from:" + collision.gameObject);
        spriteRenderer.color = Color.red;
        //gameObject.SetActive(false);
        //spriteRenderer.enabled = false;
    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        
        spriteRenderer.color = mC;
    }

}
