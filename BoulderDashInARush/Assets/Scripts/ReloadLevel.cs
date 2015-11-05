using UnityEngine;
using System.Collections;

public class ReloadLevel : MonoBehaviour
{

    public void ReloadDelay(float time = 0)
    {
        Invoke("RestartGame", time);
    }
    public void RestartGame()
    {
        Application.LoadLevel(Application.loadedLevel);
    }

    void Update()
    {
        if (Input.GetKey("r"))
        {
            RestartGame();
        }
    }
}