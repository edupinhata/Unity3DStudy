using UnityEngine;

public class Dropper : MonoBehaviour
{
    float _startTime;
    Rigidbody _rigidBody;
    private MeshRenderer _meshRenderer;
    [SerializeField] private float dropAfterSeconds;

    // Start is called before the first frame update
    void Start()
    {
       _startTime = Time.time;
       _rigidBody = GetComponent<Rigidbody>();
       _meshRenderer = GetComponent<MeshRenderer>();
       _rigidBody.useGravity = false;
       _meshRenderer.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        DropAfter(dropAfterSeconds);
    }

    void DropAfter(float time)
    {
        if (_rigidBody)

        if (Time.time - _startTime > time)
        {
            _rigidBody.useGravity = true;
            _meshRenderer.enabled = true;
        }
    }
}
