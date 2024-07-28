using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManage : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI scoreText;
    [SerializeField]
    TextMeshProUGUI scoreHigh;

    public static float score;
    int highscore;

    private void Start()
    {
        score = 0;
    }

    private void FixedUpdate()
    {
        highscore = (int)score;
        scoreText.text = "—чет: " + highscore.ToString();

        if (PlayerPrefs.GetInt("TimerStart") <= highscore)
        {
            PlayerPrefs.SetInt("TimerStart", highscore);
        }
        scoreHigh.text = "–екорд: " + PlayerPrefs.GetInt("TimerStart").ToString();
    }
}
