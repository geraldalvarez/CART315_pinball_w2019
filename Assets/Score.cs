﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    int score = 0;
    int multiplier = 1;

    public TMPro.TextMeshPro multiplierText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        this.GetComponent<TMPro.TextMeshPro>().text = score.ToString();
        multiplierText.text = "x" + multiplier.ToString();
    }

    public void AddScore(int points)
    {
        score += points * multiplier;
    }

    public void AddMultiplier(int multiplierPoint)
    {
        multiplier += multiplierPoint;
    }

    public void ResetScore()
    {
        score = 0;
    }

    public void ResetMultiplier()
    {
        multiplier = 1;
    }
}
