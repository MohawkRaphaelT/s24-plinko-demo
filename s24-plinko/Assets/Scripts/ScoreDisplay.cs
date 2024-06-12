using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreDisplay : MonoBehaviour
{
    private int score;
    public TMP_Text display;

    private void Start()
    {
        UpdateDisplay();
    }

    public void UpdateDisplay()
    {
        display.text = $"Score: {score}";
    }

    public void AddToScore(int points)
    {
        score += points;
        UpdateDisplay();
    }
}
