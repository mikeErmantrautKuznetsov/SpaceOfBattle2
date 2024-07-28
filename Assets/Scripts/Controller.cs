using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Controller : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public int score;
    public float time;
    private float timeStart;


    private void FixedUpdate()
    {
        time -= Time.deltaTime;
        if (time <= 0)
        {
            ScoreManage.score += 1;

            time = timeStart;
        }
    }
}
