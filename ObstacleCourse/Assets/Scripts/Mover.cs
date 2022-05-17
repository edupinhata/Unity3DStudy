using System;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float movementRate = 0.1f;

    private float xValue;
    private float zValue;

    
    // Start is called before the first frame update
    void Start()
    {
        PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void PrintInstructions()
    {
        Debug.Log("Welcome to the game");
        Debug.Log("Move your players with w,s,a,d or arrow keys");
        Debug.Log("Don't hit the walls");
    }

    void MovePlayer()
    {
        var verticalInput = Input.GetAxis("Vertical");
        var horizontalInput = Input.GetAxis("Horizontal");
        
        xValue = horizontalInput * movementRate * Time.deltaTime;
        zValue = verticalInput * movementRate * Time.deltaTime;
        transform.Translate(xValue, 0, zValue);
    }
}
