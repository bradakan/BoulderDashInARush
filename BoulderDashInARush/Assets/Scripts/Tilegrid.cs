using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Tilegrid : MonoBehaviour
{
    public List<int> lvl;
    public Vector2 startPoint;
    public float distanceBetweenTiles;
    public int gridWidth;
    private Vector2 currentPos;
    public GameObject outerWall;
    public GameObject innerwall;
    public GameObject rock;
    public GameObject player;
    public GameObject exit;
    public GameObject candy;
    public GameObject grass;

    private ScoreUI uiData;
    // Use this for initialization
    void Start()
    {
        uiData = GameObject.FindGameObjectWithTag("UIData").GetComponent<ScoreUI>();
        currentPos = startPoint;
        CreateLvl(GetComponent<LvlData>().lvl1);
        uiData.SetCandyINeed(GetComponent<LvlData>().lvl1candyNeeded);
        uiData.timeLeft = GetComponent<LvlData>().lvl1Time;
    }

    void CreateLvl(List<int> incomingdata)
    {
        lvl = incomingdata;
        for (int i = 0; i < lvl.Count; i++)
        {
            currentPos.x = i % gridWidth + startPoint.x;
            currentPos.y = -Mathf.Floor(i/gridWidth) + startPoint.y;
            Place(lvl[i]);
        }
    }

    void Place(int value)
    {
        switch (value)
        {
            case 0:
                Instantiate(grass, currentPos, transform.rotation);
                break;
            case 1:
                //place outerwall
                Instantiate(outerWall, currentPos, transform.rotation);
                break;
            case 2:
                //place inner wall
                Instantiate(innerwall, currentPos, transform.rotation);
                break;
            case 3:
                //place rock
                Instantiate(rock, currentPos, transform.rotation);
                break;
            case 4:
                //place candy
                Instantiate(candy, currentPos, transform.rotation);
                uiData.AddTotalCandy(1);
                break;
            case 5:
                //place Player
                Instantiate(player, currentPos, transform.rotation);
                break;
            case 6:
                //place skip
                break;
            case 7:
                //place exit
                Instantiate(exit, currentPos, transform.rotation);
                break;
            default:
                break;
        }
    }
}
