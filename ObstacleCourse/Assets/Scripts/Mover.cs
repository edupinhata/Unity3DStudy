using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float movementRate = 0.1f;

    private float xValue;
    private float zValue;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        xValue = Input.GetAxis("Horizontal") * movementRate * Time.deltaTime;
        zValue = Input.GetAxis("Vertical") * movementRate * Time.deltaTime;
        transform.Translate(xValue, 0, zValue);
    }
}
