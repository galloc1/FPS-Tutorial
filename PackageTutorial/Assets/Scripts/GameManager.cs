using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject player;
    public ScoreManager scoreManager;

    public List<GameObject> targets = new List<GameObject>();

    float gameTimer;

    enum GameState { Start, Playing, GameOver};
    GameState gameState;

    // Start is called before the first frame update
    void Start()
    {
        gameState = GameState.Start;
    }

    // Update is called once per frame
    void Update()
    {
        switch (gameState)
        {
            case GameState.Start:
                gameTimer = 0;
                gameState = GameState.Playing;
                break;
            case GameState.Playing:
                gameTimer += Time.deltaTime;

                int seconds = Mathf.RoundToInt(gameTimer);

                bool gameOver = true;

                for(int i = 0; i < targets.Count; i++)
                {
                    if(targets[i].activeSelf == true)
                    {
                        gameOver = false;
                    }
                }
                if (gameOver)
                {
                    gameState = GameState.GameOver;
                    scoreManager.AddScoreToHighscores(seconds);
                    scoreManager.SaveScoresToFile();
                }
                break;
            case GameState.GameOver:
                Debug.Log("Game has been finished");
                break;
        }
    }
}
