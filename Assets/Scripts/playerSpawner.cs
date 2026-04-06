using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    public GameObject[] characters; // your 10 prefabs
    public Transform spawnPoint;

    private GameObject currentCharacter;

    void Start()
    {
        int index = CharManager.selectedChar;
        currentCharacter = Instantiate(characters[index], spawnPoint.position, Quaternion.identity);
    }
}