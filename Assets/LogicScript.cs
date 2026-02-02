using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int score = 0;
    public Text scoreText;
    public GameObject gameOverPanel;

    public void AddScore()
    {
        score += 1;
        scoreText.text = score.ToString();
    }

    public void ResetScore()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;
    }

    public void GameOver()
    {
        gameOverPanel.SetActive(true);
        Time.timeScale = 0f;
    }

}
