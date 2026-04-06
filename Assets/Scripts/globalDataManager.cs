using UnityEngine;

public class globalDataManager : MonoBehaviour
{

    public static int totalScore;
    public static int totalCoins;

    public void Awake()
    {
        DontDestroyOnLoad(gameObject);
        totalScore = PlayerPrefs.GetInt("TotalScore", 0);
        totalCoins = PlayerPrefs.GetInt("TotalCoins", 0);
    }


    public static void AddScore( int scoreAmount)
    {
        totalScore += scoreAmount;
        PlayerPrefs.SetInt("TotalScore", totalScore);
        PlayerPrefs.Save();
    }

    public static void AddCoins(int coinAmount)
    {
        totalCoins += coinAmount;
        PlayerPrefs.SetInt("TotalCoins", totalCoins);
        PlayerPrefs.Save();
    }
}
