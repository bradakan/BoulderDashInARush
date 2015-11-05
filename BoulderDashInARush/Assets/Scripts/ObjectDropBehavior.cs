using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ObjectDropBehavior : MonoBehaviour
{
    public int myType;
    public List<int> currentLvlData;
    Tilegrid gridHandler;
    public bool isMoving = false;
    float cooldownRecorded = 0;
    float cooldownDelay;

    // Use this for initialization
    void Start()
    {

        cooldownDelay = GameObject.FindGameObjectWithTag("GameSpeed").GetComponent<GameSpeed>().gameSpeed;
        gridHandler = GameObject.FindGameObjectWithTag("GridHandler").GetComponent<Tilegrid>();
        currentLvlData = gridHandler.lvl;
    }

    // Update is called once per frame
    
    void LateUpdate()
    {
        if (Time.time > cooldownRecorded)
        {
            cooldownRecorded = Time.time + cooldownDelay;
            //Debug.Log((int)transform.position.x + ((int)transform.position.y + 1) * gridHandler.gridWidth);
            if (currentLvlData[(int)transform.position.x + ((int)Mathf.Abs(transform.position.y) + 1) * gridHandler.gridWidth] == 5 && isMoving)
            {
                Debug.Log("kill player");
                GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>().Explode();
                //GameObject.FindGameObjectWithTag("RelaodLvlObject").GetComponent<ReloadLevel>().ReloadDelay(3);
                GameObject.FindGameObjectWithTag("ToggleEndGameScreen").GetComponent<ToggleEndGameScreen>().Loose();
            }
            else if (currentLvlData[(int)transform.position.x + ((int)Mathf.Abs(transform.position.y) + 1) * gridHandler.gridWidth] == 6)
            {
                isMoving = true;
                currentLvlData[(int)transform.position.x + ((int)Mathf.Abs(transform.position.y) + 1) * gridHandler.gridWidth] = myType;
                currentLvlData[(int)transform.position.x + ((int)Mathf.Abs(transform.position.y)) * gridHandler.gridWidth] = 6;
                transform.Translate(new Vector2(0, -1));
            }
            else if (currentLvlData[(int)transform.position.x + ((int)Mathf.Abs(transform.position.y) + 1) * gridHandler.gridWidth] == 3 || currentLvlData[(int)transform.position.x + ((int)Mathf.Abs(transform.position.y) + 1) * gridHandler.gridWidth] == 4)
            {
                if (currentLvlData[(int)transform.position.x - 1 + ((int)Mathf.Abs(transform.position.y) + 1) * gridHandler.gridWidth] == 6 && currentLvlData[(int)transform.position.x - 1 + ((int)Mathf.Abs(transform.position.y)) * gridHandler.gridWidth] == 6)
                {
                    isMoving = true;
                    currentLvlData[(int)transform.position.x - 1 + ((int)Mathf.Abs(transform.position.y)) * gridHandler.gridWidth] = myType;
                    currentLvlData[(int)transform.position.x + ((int)Mathf.Abs(transform.position.y)) * gridHandler.gridWidth] = 6;
                    transform.Translate(new Vector2(-1, 0));
                }
                else if (currentLvlData[(int)transform.position.x + 1 + ((int)Mathf.Abs(transform.position.y) + 1) * gridHandler.gridWidth] == 6 && currentLvlData[(int)transform.position.x + 1 + ((int)Mathf.Abs(transform.position.y)) * gridHandler.gridWidth] == 6)
                {
                    isMoving = true;
                    currentLvlData[(int)transform.position.x + 1 + ((int)Mathf.Abs(transform.position.y)) * gridHandler.gridWidth] = myType;
                    currentLvlData[(int)transform.position.x + ((int)Mathf.Abs(transform.position.y)) * gridHandler.gridWidth] = 6;
                    transform.Translate(new Vector2(1, 0));
                }
                else
                {
                    isMoving = false;
                }
            }

            else
            {
                isMoving = false;
            }
        }
    }
}
