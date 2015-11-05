using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ToggleEndGameScreen : MonoBehaviour {

    public GameObject gameOverOrCongratsText;
    public GameObject yourScore;
    public GameObject panel;
    ScoreUI uiData;

    void Start()
    {
        uiData = GameObject.FindGameObjectWithTag("UIData").GetComponent<ScoreUI>();
    }
    public void Loose()
    {
        Invoke("Lost", 3f);
    }

    public void Lost()
    {
        Toggle(false);
    }
    public void Toggle(bool win)
    {
        gameOverOrCongratsText.SetActive(true);
        yourScore.SetActive(true);
        panel.SetActive(true);
        if (win)
        {
            gameOverOrCongratsText.GetComponent<Text>().text = "Congratulations";
            yourScore.GetComponent<Text>().text = "Your Score :" + (uiData.score + uiData.timeLeft).ToString();

            
        }
        else
        {
            gameOverOrCongratsText.GetComponent<Text>().text = "Game Over";
            yourScore.GetComponent<Text>().text = "Your Score :" + (uiData.score + uiData.timeLeft).ToString();
        }

    }
}
