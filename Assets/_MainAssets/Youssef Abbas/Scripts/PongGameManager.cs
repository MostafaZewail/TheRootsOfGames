using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PongGameManager : MonoBehaviour
{
    public DeadBall dead;
    [SerializeField] private int finalScore = 5;
    [SerializeField] private Animator anim;
    public GameObject loseWindow;
    private int levelToLoad;

    private void Start()
    {
        loseWindow.SetActive(false);
        Time.timeScale = 1f;
    }
    private void Update()
    {
        if (dead.PlayerScore == finalScore)
        {
            FadeToLevel(2);

        }

        else if (dead.EnemyScore == finalScore)
        {
            loseWindow.SetActive(true);
            Time.timeScale = 0f;
        }
    }


    public void FadeToLevel(int levelIndex)
    {
        levelToLoad = levelIndex;
        anim.SetTrigger("FadeOut");

    }

    public void OnFadeComplete()
    {
        SceneManager.LoadScene(levelToLoad);
    }


    public void MainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        
        Debug.Log("Restarted");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
