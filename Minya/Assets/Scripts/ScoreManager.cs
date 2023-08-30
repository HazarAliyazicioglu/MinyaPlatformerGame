using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    CoinManager coins;
    PlayerManager lScore;
    DeathAreaManager sbFalling;
    
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI lastScoreText;

    public int score = 0;
    int lastScore;
    // Start is called before the first frame update
    void Start()
    {
        coins = FindObjectOfType<CoinManager>();
        coins.AddingScore += AddScore;
        
        lScore = FindObjectOfType<PlayerManager>();
        lScore.LastScore += LastScore;
        
        sbFalling = FindObjectOfType<DeathAreaManager>();
        sbFalling.sbfalling += LastScore;
    }

    public void AddScore()
    {
        score += 1;
        scoreText.text = "Score: " + score.ToString();
    }

    void LastScore()
    {
        lastScore = score;
        lastScoreText.text = "Your Score: " + lastScore.ToString();
    }
    
}
