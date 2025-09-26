using UnityEngine;
using TMPro; // Use this if you’re using TextMeshPro
using UnityEngine.SceneManagement;
public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI winText;
    //public BallController ball;
    int score = 0;

public void AddScore(int input)
    {
        if (input == 1) {
            score += input;
            scoreText.text = score.ToString() + "Points";
        }
        if (score == 5) { // for testing purpose
            winText.text = "You Win!";
            //ball.setActive(false);
            SceneManager.LoadScene("Level2");
        }
        else if (input == 0) {
            winText.text = "Game Over!";
        }
    }
}
