using UnityEngine;
using UnityEngine.Serialization;

public class Movement : MonoBehaviour
{
    private Rigidbody rb;
    [FormerlySerializedAs("power")] [SerializeField] private float mainThrust;
    [FormerlySerializedAs("rotationPower")] [SerializeField] private float rotationThrust;
    
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
            ApplyRotation(rotationThrust);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            ApplyRotation(-rotationThrust);
        }
        else
        {
            rb.freezeRotation = false;
        }
    }

    private void ApplyRotation(float rotationThisFrame)
    {
        rb.freezeRotation = true; 
        transform.Rotate(Vector3.forward * rotationThisFrame * Time.deltaTime);
    }

    private void ProcessThrust()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("Trust!!!");
            rb.AddRelativeForce(Vector3.up * (Time.deltaTime * mainThrust));
        }
    }
}
