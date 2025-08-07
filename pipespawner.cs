using UnityEngine;

public class PillarMovement : MonoBehaviour
{
    public float moveSpeed = 2f;
    public float leftBound = -10f;

    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;

        if (transform.position.x < leftBound)
        {
            Destroy(gameObject);
        }
    }
}
