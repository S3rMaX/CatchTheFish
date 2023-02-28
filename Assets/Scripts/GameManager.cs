using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    private GameObject gameOverPanel;
    [SerializeField]
    private bool isGameOver = false;

    private void Awake()
    {
        Instance = this;
        gameOverPanel = GameObject.Find("Game Over Panel");
        gameOverPanel.SetActive(false);
    }

    private void Start()
    {
        StartGame();
    }
    public void StartGame()
    {
        isGameOver = false;
        FishSpawner.Instance.GetFishes();
        FishSpawner.Instance.StartSpawnFishes();
        GameObject.Find("Player").GetComponent<PlayerController>().IsMoving = true;
    }

    public void GameOver()
    {
        isGameOver = true;
        FishSpawner.Instance.StopSpawnFishes();
        GameObject.Find("Player").GetComponent<PlayerController>().IsMoving = false;
        gameOverPanel.SetActive(true);
    }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void LoadScene(int sceneNumber)
    {
        SceneManager.LoadScene(sceneNumber);
    }
}
