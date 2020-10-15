using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField]
    private Text highscoreText;

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("HIGHSCORE"))
        {
            highscoreText.text = "Highscore : " + PlayerPrefs.GetInt("HIGHSCORE");
        }
        else
        {
            highscoreText.text = "Highscore : -";
        }

        Time.timeScale = 1;
    }
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
    public void Exit()
    {
        Application.Quit();
    }
}
