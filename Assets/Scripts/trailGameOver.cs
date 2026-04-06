using UnityEngine;

public class trailGameOver : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {

            Time.timeScale = 0f;
        }
    }
}
