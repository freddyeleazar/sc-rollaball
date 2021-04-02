using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreTextController : MonoBehaviour
{
    private TextMeshProUGUI scoreText;

    private void Awake()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
        EventBroker.UpdateScore += SetScoreText;
        SetScoreText(0);
    }

    private void SetScoreText(int score)
    {
        scoreText.text = "Score: " + score.ToString();
    }
}
