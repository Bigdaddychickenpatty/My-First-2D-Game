using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public bool IsGameActive;
    public Button RestartButton;
    public TextMeshProUGUI GameOverText;

    // Start is called before the first frame update
    void Start()
    {
        IsGameActive = false;
    }
      public void Gameover()
    {
        IsGameActive = false;
        GameOverText.gameObject.SetActive(true);
        RestartButton.gameObject.SetActive(true);
    }
public void StartGame()
{
     IsGameActive = true;
}
    // Update is called once per frame
    void Update()
    {
        
    }
}
