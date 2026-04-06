using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float jumpSpeed = 10f;
    private Rigidbody rb;

    // These might be null depending on the scene
    private trailScore trailScore;
    private ObstacleRUNScript obstacleRUNScript;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        // Find whichever manager is present in the current scene
        trailScore = GameObject.FindAnyObjectByType<trailScore>();
        obstacleRUNScript = GameObject.FindAnyObjectByType<ObstacleRUNScript>();

        // IMPORTANT: Reset time in case the last game ended with a freeze
        Time.timeScale = 1f;
    }

    void Update()
    {
        // Jump Input (Works for Keyboard and Touch)
        bool jumpPressed = false;
        if (Keyboard.current != null && Keyboard.current.spaceKey.wasPressedThisFrame) jumpPressed = true;
        if (Touchscreen.current != null && Touchscreen.current.primaryTouch.press.wasPressedThisFrame) jumpPressed = true;

        if (jumpPressed)
        {
            // Resetting velocity Y before adding force makes the jump feel consistent
         
            rb.AddForce(Vector3.up * jumpSpeed, ForceMode.Impulse);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        // Death Logic
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Time.timeScale = 0f;
            Debug.Log("Hit Obstacle - Game Over");
            SceneManager.LoadScene("GameOver");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        // Null checks prevent the script from crashing if a manager is missing
        if (other.gameObject.CompareTag("platform") && trailScore != null)
        {
            trailScore.updateScore(1);
        }

        if (other.gameObject.CompareTag("Obstacle") && obstacleRUNScript != null)
        {
            obstacleRUNScript.updateObstacleScore(1);
        }

    }
}