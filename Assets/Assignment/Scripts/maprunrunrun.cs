using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makealot : MonoBehaviour
{
    public GameObject stage;
    public int howmanystage = 100;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 150; i++)
        {
            Instantiate(stage, new Vector2(Random.Range(5, -5), Random.Range(3, 77)), transform.rotation);
        }
    }








}

