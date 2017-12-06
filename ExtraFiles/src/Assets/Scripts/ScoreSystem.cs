﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{

    public static int score;
    Text scoreText;

    void Start()
    {
        scoreText = GetComponent<Text>();

        score = 0;
    }
    // Update is called once per frame
    void Update()
    {
        if (score < 0) score = 0;

        scoreText.text = "Score: " + score;
    }

    public static void pointsToAdd(int points)
    {
        score += points;
    }

    public static void reset()
    {
        score = 0;
    }
}
