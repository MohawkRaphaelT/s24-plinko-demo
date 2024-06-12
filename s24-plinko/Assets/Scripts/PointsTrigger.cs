using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointsTrigger : MonoBehaviour
{
    public int points = 1;
    public ScoreDisplay scoreDisplay;

    public void OnTriggerEnter2D(Collider2D collider)
    {
        // when entered, add score somewhere
        scoreDisplay.AddToScore(points);
    }
}
