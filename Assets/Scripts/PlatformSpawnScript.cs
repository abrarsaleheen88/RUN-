using Unity.VisualScripting;
using UnityEngine;

public class PlatformSpawnScript : MonoBehaviour
{
    public GameObject platform;
    private float start = 0.9f;
    private float repeat = 1.5f;
    private float randomY;
    private Vector3 spawnPos ;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
      
    InvokeRepeating("SpawnPlatform", start, repeat);
        
    }

    // Update is called once per frame
   void SpawnPlatform()
    {
        spawnPos = new Vector3(25,-4, 0);
        Instantiate(platform, spawnPos, platform.transform.rotation);
    }
}
