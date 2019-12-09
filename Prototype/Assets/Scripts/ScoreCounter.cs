using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    private Text currentScore = null;
    private int currentIntScore;
    private Text highScore = null;
    private int highIntScore;

    // Start is called before the first frame update
    void Awake()
    {
        currentScore = transform.GetChild(0).GetComponent<Text>();
        currentScore.text = "0";

        highScore = transform.GetChild(1).GetComponent<Text>();
        highIntScore = PlayerPrefs.GetInt("HighScore");
        if (highIntScore != 0)
            highScore.text = highIntScore.ToString();
        else
            highScore.text = "0";
    }

    public void AddCurrentScore(int value)
    {
        currentIntScore += value;
        currentScore.text = currentIntScore.ToString();
    }

    public void AddHighScore()
    {
        if (currentIntScore > highIntScore)
        {
            PlayerPrefs.SetInt("HighScore", currentIntScore);
        }
    }

}
