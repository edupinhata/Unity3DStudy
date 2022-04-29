using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetcHit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnCollisionEnter(Collision collision)
    { 
        Debug.Log("Bumpped into a Wall");
        GetComponent<MeshRenderer>().material.color = Color.red;
    
        
    }
}
