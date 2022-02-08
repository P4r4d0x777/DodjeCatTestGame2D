using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager _instance;

    public bool _gameOver = false;

    public int _score = 0;

    public Text _scoreText;

    public GameObject _gameOverPanel;
    private void Awake()
    {
        if(_instance == null)
        {
            _instance = this;
        }
    }

    public void GameOver()
    {
        _gameOver = true;

        GameObject.Find("EnemySpawner").GetComponent<EnemySpawner>().StopSpawning();

        _gameOverPanel.SetActive(true);
    }
    public void IncrementScore()
    {
        if (!_gameOver)
        {
            _score++;

            Debug.Log(_score);

            _scoreText.text = _score.ToString();
        }
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Main");
    }

    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }
}
