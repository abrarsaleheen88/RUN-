using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShowTotalScore : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI coinText;

    void Start()
    {
        scoreText.text = "Total Score: " + globalDataManager.totalScore;
        coinText.text = "Total Coins" + globalDataManager.totalCoins;
       
    }
}