using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseCollider : MonoBehaviour
{

    [SerializeField] GameSession gameSession;
    BallScript ball;

    private void Start()
    {
        gameSession = FindObjectOfType<GameSession>();
        ball = FindObjectOfType<BallScript>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameSession.lives <= 0)
        {
            SceneManager.LoadScene("Game Over");
        }
        else
        {
            gameSession.lives--;
            gameSession.UpdateLives();
            ball.LockBallToPaddle();
            ball.hasStarted = false;
            ball.LaunchOnMouseClick();          
        }
    }
}
