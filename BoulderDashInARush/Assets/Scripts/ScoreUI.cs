using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour {

    public int candyIAte;
    public int candyINeed;
    public int totalCandy;
    public int timeLeft;
    public int score;
    public Text totalCandyText;
    public Text candyINeedText;
    public Text candyIAteText;
    public Text timeLeftText;
    public Text scoreText;

    
    public void StartTime()
    {
        timeDown();
        timeLeftText.text = "time left : " + timeLeft.ToString();
    }

    void timeDown()
    {
        timeLeft--;
        timeLeftText.text = "time left : " + timeLeft.ToString();
        if (timeLeft <= 0)
        {
            Debug.Log("Game Over");

        }

        Invoke("timeDown", 1);
    }

    public void AddTotalCandy(int amount)
    {
        totalCandy += amount;
        totalCandyText.text = "total candy : " + totalCandy.ToString();
        //changetext
    }
    public void AddCandyIAte(int amount = 1)
    {
        candyIAte += amount;
        candyIAteText.text = "candy i have : " + candyIAte.ToString();
        AddScore(10);
    }
    public void SetCandyINeed(int amount)
    {
        candyINeed = amount;
        candyINeedText.text = "candy needed : " + candyINeed.ToString();
    }

    public void AddScore(int amount)
    {
        score += amount;
        scoreText.text = "score : " + score.ToString();
    }
}
