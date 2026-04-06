using UnityEngine;

public class PlatformScript : MonoBehaviour
{
    private trailScore trailScore;
    private trailScore trailScorePassedPlatform;
     void Start()
    {
        
    }






    void Update()
    {
        transform.Translate(Vector3.left * 10f * Time.deltaTime);
    }

   
}
