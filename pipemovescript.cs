using UnityEngine;

public class pipemovescript : MonoBehaviour
{
    public float moveSpeed = 2f;
    public float leftBound = -15f; // This is the correct variable

    void Update()
    {
        // Move the pipe left
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;

        // Destroy if it goes off screen
        if (transform.position.x < leftBound)
        {
            Destroy(gameObject);
        }
    }
}
