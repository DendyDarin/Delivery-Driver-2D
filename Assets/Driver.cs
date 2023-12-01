using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    float steerSpeed

    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(0, 0, 0.1f);
        transform.Translate(0, 0.01f, 0);
    }
}
