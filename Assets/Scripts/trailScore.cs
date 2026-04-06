using UnityEngine;
using TMPro;


public class trailScore : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI coinText;
    private int score =0;
    private int coins=0;
    private globalDataManager globalDataManager;
   
    void Start()
    {
        scoreText.text = "Score : " + score;
        coinText.text = "Coins : " + coins;
        globalDataManager = FindAnyObjectByType<globalDataManager>();

    }

 public  void  updateScore(int AddScore)
    { score += AddScore;
        scoreText.text = "Score : " + score;
        globalDataManager.AddScore(AddScore);
    }

   public  void updateCoins(int AddCoin)
    {
        coins += AddCoin;
        coinText.text = "Coins : " + coins;
        globalDataManager.AddCoins(AddCoin);

    }
}
