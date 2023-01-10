using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool IsGameActive;
    public Button RestartButton;
    public TextMeshProUGUI GameOverText;
    public float SpawnRate = 1f;
    public int Score = 0;
    public TextMeshProUGUI ScoreText;
    public int PointValue = 1;
    public List<GameObject> Enemy;

    private GameManager _gameManager;

    // Start is called before the first frame update
    void Start()
    {
        IsGameActive = false;
    }
    
public void StartGame()
{
    ScoreText.gameObject.SetActive(true); 
    IsGameActive = true;
    ScoreText.text = "Score: " + Score;
}
  public void Gameover()
    {
        IsGameActive = false;
        GameOverText.gameObject.SetActive(true);
        RestartButton.gameObject.SetActive(true);
    }
 public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

      public void UpdateScore(int addToScore)
    {
        Score += addToScore;
        Debug.Log("Score: " + Score.ToString());
        ScoreText.text = "Score: " + Score.ToString();
    }

}
