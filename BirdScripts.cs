using UnityEngine;

public class BirdController : MonoBehaviour
{
    public float flapForce = 5f; // Force applied when the bird flaps
    private Rigidbody2D rb;
    private bool isGameOver = false; // Track if the game is over

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Check for user input (space or tap) only if the game is not over
        if (!isGameOver && (Input.GetKeyDown(KeyCode.Space) || Input.touchCount > 0))
        {
            Flap();
        }
    }

    void Flap()
    {
        rb.linearVelocity = Vector2.up * flapForce; // Apply upward force
    }

    // Method to handle game over
    public void GameOver()
    {
        isGameOver = true;
        rb.linearVelocity = Vector2.zero; // Stop the bird's movement
        // Optionally, you can add more game over logic here (e.g., show UI)
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Pillar") || collision.gameObject.CompareTag("Ground"))
        {
            GameOver(); // Call GameOver method if bird hits a pillar or ground
        }
    }
}
