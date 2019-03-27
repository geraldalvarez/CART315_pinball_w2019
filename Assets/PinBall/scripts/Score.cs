using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    int score = 0;
    int multiplier = 1;

    //public TMPro.TextMeshPro multiplierText;
    public Text scoreText;
    public Text multiplierText;

    private float multiplierTimer;
    private float multiplierInterval = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //this.GetComponent<TMPro.TextMeshPro>().text = score.ToString();
        scoreText.text = score.ToString();
        multiplierText.text = "x" + multiplier.ToString();

        //decrementing the multiplier by time
        multiplierTimer += Time.fixedDeltaTime;

        if (multiplierTimer > multiplierInterval)
        {
            //make the multiplier does not go below 1
            if(multiplier > 1)
            {
                multiplier--;
            }

            multiplierTimer -= multiplierInterval;
        }


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

    public int getScore()
    {
        return score;
    }

    public int getMultiplier()
    {
        return multiplier;
    }
}
