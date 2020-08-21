using UnityEngine;
using UnityEngine.UI;

public class AddScore : MonoBehaviour
{
    public Text _scoreText;
    public static AddScore inGameScore;
    private static int Score;

    private void Awake()
    {
        inGameScore = this;
    }

    public void AddScoreOnTap()
    {
        Score++;
        _scoreText.text = Score.ToString();
    }
}
