using UnityEngine;

public class ObstacleScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
  

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * 10f *Time.deltaTime,Space.World);
    }
}
