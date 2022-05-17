using UnityEngine;

public class Scorer : MonoBehaviour
{
    [SerializeField] int totalScore = 0;

    void OnCollisionEnter(Collision other)
    {
        if (!other.gameObject.CompareTag("Hit"))
        {
            totalScore += 1;
            Debug.Log($"Total score: {totalScore}");
        }
    }
}