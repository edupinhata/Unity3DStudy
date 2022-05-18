using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody rb; 
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        ProcessThrust(); 
        ProcessRotation();
    }
    
    void ProcessRotation()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, 0, 10*Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 0, -10*Time.deltaTime);
        }

    }

    private void ProcessThrust()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("Trust!!!");
            rb.AddRelativeForce(Vector3.up);
        }
    }
}
