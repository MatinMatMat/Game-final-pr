using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;



public class UiManager : MonoBehaviour
{
    public Button[] buttons;
    int score;
    public TMPro.TextMeshProUGUI ScoreText;
    public bool gameOver;

    // Start is called before the first frame update
    void Start()
    {
        gameOver = false;
        score = 0;
        InvokeRepeating("scoreUpdate", 1.0f, 0.5f);

    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = "Score: " + score;
    }

    void scoreUpdate()
    {
        if (!gameOver)
        {
            score += 1;
        }
    }


    public void gameOverActivate()
    {
        gameOver = true;
        foreach (Button button in buttons) {

            button.gameObject.SetActive(true);
        
        }


    }
    public void Play()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void Pause()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
        }
        else if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
        }
    }

    public void Menu()
    {
        SceneManager.LoadScene("menuScene");
    }

    public void Exit()
    {
        Application.Quit();
    }



}
