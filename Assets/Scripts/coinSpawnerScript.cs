using UnityEngine;

public class coinSpawnerScript : MonoBehaviour
{
    public GameObject coin;
    private float start = 0.9f;
    private float repeat = 2.5f;
    private float randomY;
    private Vector3 spawnPos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {


        InvokeRepeating("SpawnCoin", start, repeat);

    }

    // Update is called once per frame
    void SpawnCoin()
    {
        spawnPos = new Vector3(25, 0, 0);
        Instantiate(coin, spawnPos, coin.transform.rotation);
    }
}
