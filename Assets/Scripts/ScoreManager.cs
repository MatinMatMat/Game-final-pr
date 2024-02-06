using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    //float pointIncreasePerSecond;
    public float score;
    public TMPro.TextMeshProUGUI ScoreText;
    public float pointsPerSecond ;
    // Start is called before the first frame update
    void Start()
    {
        score = 0f;
        pointsPerSecond = 1f;

    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = "Score: " + (int)score;
        score += pointsPerSecond * Time.deltaTime;
    }
}
