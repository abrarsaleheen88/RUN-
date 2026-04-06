using Unity.VisualScripting;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public GameObject obstacle;
    private float start =2f;
    private float repeat = 4f;
    private Vector3 spawnPos = new Vector3(25, 0.5f, 0);
   
    private float randomY;
    void Start()
    {
        InvokeRepeating("spawnManager",start,repeat);
    }

    // Update is called once per frame
   void spawnManager()
    {
    
        spawnPos = new Vector3(25, 0, 0);
        Instantiate(obstacle, spawnPos, obstacle.transform.rotation);
    }
}
