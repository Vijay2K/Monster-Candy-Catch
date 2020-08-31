using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    int Score = 0;

    bool GameOver = false;
    public Text ScoreText;

    public GameObject Life;
    public GameObject gameOverPanel;

    int Lives = 5;


    public static GameManager Instance;

    private void Awake()
    {
        Instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ScoreIncrement()
    {
        Score++;
        ScoreText.text = Score.ToString();
        
    }
    public void DecrementLife()
    {
        if (Lives > 0)
        {
            Lives--;
            print(Lives);

            Life.transform.GetChild(Lives).gameObject.SetActive(false);
        }
        if (Lives <= 0)
        {
            GameOver = true;

            Gameover();
        }
    }
    public void Gameover()
    {
        CandySpawn.Instance.StopSpawnCandies();
        GameObject.Find("Player").GetComponent<PlayerController>().CanMove = false;
        gameOverPanel.SetActive(true);

        print("GameOver!");
    }
    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }
    public void Menu()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
