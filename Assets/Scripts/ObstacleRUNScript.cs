using TMPro;
using UnityEngine;

public class ObstacleRUNScript : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private globalDataManager globalDataManager;
   
    private int score = 0;
   
    void Start()
    {
        scoreText.text = "Score : " + score;
        globalDataManager = FindAnyObjectByType<globalDataManager>();

    }

    public void updateObstacleScore(int AddScore)
    {
        score += AddScore;
        scoreText.text = "Score : " + score;
        globalDataManager.AddScore(AddScore);  
    }

    
}
