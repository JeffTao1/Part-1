using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makealot : MonoBehaviour
{
    public GameObject stage;
   

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 150; i++)//make a for loop to make alot stage
        {
            Instantiate(stage, new Vector2(Random.Range(5, -5), Random.Range(3, 147)), transform.rotation);// where should the stage show 
        }
    }








}

