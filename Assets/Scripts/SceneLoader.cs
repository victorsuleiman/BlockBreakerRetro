using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    GameSession gamestatus;
    Music music;

    public void LoadNextScene()
    {

        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);

    }


    public void PlayAgain()
    {

        SceneManager.LoadScene(0);
        gamestatus = FindObjectOfType<GameSession>();
        gamestatus.ResetGame();
        music = FindObjectOfType<Music>();
        music.ResetMusic();
    }

    public void QuitGame()
    {

        Application.Quit();

    }
}
