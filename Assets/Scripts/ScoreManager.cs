using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    private int score;
    private TextMeshProUGUI scoreTextUI;

    private void Awake()
    {
        instance = this;
        scoreTextUI = GameObject.Find("ScoreTextUI").GetComponent<TextMeshProUGUI>(); ;
    }

        public void AddScore()
        {
            score++;
            AddScoreUI();
        }

        private void AddScoreUI()
        {
            scoreTextUI.text = score.ToString();
        }
}
