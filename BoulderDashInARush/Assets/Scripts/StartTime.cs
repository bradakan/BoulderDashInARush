using UnityEngine;
using System.Collections;

public class StartTime : MonoBehaviour
{
    ScoreUI uiData;
    // Use this for initialization
    void Start()
    {
        uiData = GameObject.FindGameObjectWithTag("UIData").GetComponent<ScoreUI>();
        uiData.StartTime();
    }
}
