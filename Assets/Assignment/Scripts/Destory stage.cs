using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destorystage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionExit2D(Collision2D collision)// after player leave the stage the stage will destroy
    {
        Destroy(gameObject);
    }
}
