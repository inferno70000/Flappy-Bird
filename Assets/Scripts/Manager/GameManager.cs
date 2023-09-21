using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Threading;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    private Transform scoreText;
    private Transform startGameText;
    private Transform panel; 
    [SerializeField] private bool isGameOver;
    [SerializeField] private int point;

    public static GameManager Instance { get => instance; }
    public bool IsGameOver { get => isGameOver; }
    public int Point { get => point; }

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Only 1 Game Manager exists");
        }

        instance = this;

        panel = GameObject.FindGameObjectWithTag("Panel").transform;
        scoreText = panel.Find("ScoreText");
        startGameText = panel.Find("StartGameText");
    }

    private void Start()
    {
        Pause();
    }

    private void Update()
    {
        DisableMoveLeft();
        StartGame();
    }

    public virtual void SetGameOver(bool isGameOver)
    {
        this.isGameOver = isGameOver;   
    }

    public virtual void DisableMoveLeft()
    {
        if (!isGameOver) { return; }

        foreach (var gameObj in FindObjectsOfType<MoveLeft>())
        {
            gameObj.enabled = false;
        }
    }

    public virtual void AddPoint(int point)
    {
        this.point += point;
    }

    public virtual void Pause()
    {
        Time.timeScale = 0f;
    }

    public virtual void Resume() 
    {
        Time.timeScale = 1f; 
    }

    private void StartGame()
    {
        if (InputManager.Instance.GetJumpButton())
        {
            Resume();
            scoreText.gameObject.SetActive(true);
            startGameText.gameObject.SetActive(false);
        }
    }
}
