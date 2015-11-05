using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerMovement : MonoBehaviour
{

    int myType = 5;
    public List<int> currentLvlData;
    Tilegrid gridHandler;
    ScoreUI uiData;
    GameObject mainCamera;
    float cooldownRecorded = 0;
    float cooldownDelay;
    public GameObject explosion;
    public ToggleEndGameScreen toggleEndScreen;


    // Use this for initialization
    void Start()
    {
        toggleEndScreen = GameObject.FindGameObjectWithTag("ToggleEndGameScreen").GetComponent<ToggleEndGameScreen>();
        cooldownDelay = GameObject.FindGameObjectWithTag("GameSpeed").GetComponent<GameSpeed>().gameSpeed;
        uiData = GameObject.FindGameObjectWithTag("UIData").GetComponent<ScoreUI>();
        gridHandler = GameObject.FindGameObjectWithTag("GridHandler").GetComponent<Tilegrid>();
        currentLvlData = gridHandler.lvl;
        mainCamera = GameObject.FindGameObjectWithTag("MainCamera");
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > cooldownRecorded)
        {
            cooldownRecorded = Time.time + cooldownDelay;

            if (Input.GetKey("space") && Input.GetKey("d") || Input.GetKey("space") && Input.GetKey("right"))
            {
                if (currentLvlData[(int)transform.position.x + 1 + ((int)Mathf.Abs(transform.position.y)) * gridHandler.gridWidth] == 6 || currentLvlData[(int)transform.position.x + 1 + ((int)Mathf.Abs(transform.position.y)) * gridHandler.gridWidth] == 0 || currentLvlData[(int)transform.position.x + 1 + ((int)Mathf.Abs(transform.position.y)) * gridHandler.gridWidth] == 4)
                {
                    Collider2D[] colliders = Physics2D.OverlapCircleAll(new Vector2(transform.position.x + 1, transform.position.y), 0.1f);
                    if (colliders.Length > 0)
                    {
                        foreach (var item in colliders)
                        {
                            Destroy(item.gameObject);
                        }
                    }
                    if (currentLvlData[(int)transform.position.x + 1 + ((int)Mathf.Abs(transform.position.y)) * gridHandler.gridWidth] == 4)
                    {
                        Debug.Log("ate candy");
                        uiData.AddCandyIAte();
                    }

                    currentLvlData[(int)transform.position.x + 1 + ((int)Mathf.Abs(transform.position.y)) * gridHandler.gridWidth] = 6;
                }
            }
            else if (Input.GetKey("space") && Input.GetKey("a") || Input.GetKey("space") && Input.GetKey("left"))
            {
                if (currentLvlData[(int)transform.position.x - 1 + ((int)Mathf.Abs(transform.position.y)) * gridHandler.gridWidth] == 6 || currentLvlData[(int)transform.position.x - 1 + ((int)Mathf.Abs(transform.position.y)) * gridHandler.gridWidth] == 0 || currentLvlData[(int)transform.position.x - 1 + ((int)Mathf.Abs(transform.position.y)) * gridHandler.gridWidth] == 4)
                {

                    Collider2D[] colliders = Physics2D.OverlapCircleAll(new Vector2(transform.position.x - 1, transform.position.y), 0.1f);
                    if (colliders.Length > 0)
                    {
                        foreach (var item in colliders)
                        {
                            Destroy(item.gameObject);
                        }
                    }
                    Debug.Log("eating left");
                    if (currentLvlData[(int)transform.position.x - 1 + ((int)Mathf.Abs(transform.position.y)) * gridHandler.gridWidth] == 4)
                    {
                        uiData.AddCandyIAte();
                    }

                    currentLvlData[(int)transform.position.x - 1 + ((int)Mathf.Abs(transform.position.y)) * gridHandler.gridWidth] = 6;
                }
            }
            else if (Input.GetKey("space") && Input.GetKey("w") || Input.GetKey("space") && Input.GetKey("up"))
            {
                if (currentLvlData[(int)transform.position.x + ((int)Mathf.Abs(transform.position.y) - 1) * gridHandler.gridWidth] == 6 || currentLvlData[(int)transform.position.x + ((int)Mathf.Abs(transform.position.y) - 1) * gridHandler.gridWidth] == 0 || currentLvlData[(int)transform.position.x + ((int)Mathf.Abs(transform.position.y) - 1) * gridHandler.gridWidth] == 4)
                {

                    Collider2D[] colliders = Physics2D.OverlapCircleAll(new Vector2(transform.position.x, transform.position.y + 1), 0.1f);
                    if (colliders.Length > 0)
                    {
                        foreach (var item in colliders)
                        {
                            Destroy(item.gameObject);
                        }
                    }
                    Debug.Log("eating up");
                    if (currentLvlData[(int)transform.position.x + ((int)Mathf.Abs(transform.position.y) - 1) * gridHandler.gridWidth] == 4)
                    {
                        uiData.AddCandyIAte();
                    }

                    currentLvlData[(int)transform.position.x + ((int)Mathf.Abs(transform.position.y) - 1) * gridHandler.gridWidth] = 6;
                }
            }
            else if (Input.GetKey("space") && Input.GetKey("s") || Input.GetKey("space") && Input.GetKey("down"))
            {
                if (currentLvlData[(int)transform.position.x + ((int)Mathf.Abs(transform.position.y) + 1) * gridHandler.gridWidth] == 6 || currentLvlData[(int)transform.position.x + ((int)Mathf.Abs(transform.position.y) + 1) * gridHandler.gridWidth] == 0 || currentLvlData[(int)transform.position.x + ((int)Mathf.Abs(transform.position.y) + 1) * gridHandler.gridWidth] == 6)
                {

                    Collider2D[] colliders = Physics2D.OverlapCircleAll(new Vector2(transform.position.x, transform.position.y - 1), 0.1f);
                    if (colliders.Length > 0)
                    {
                        foreach (var item in colliders)
                        {
                            Destroy(item.gameObject);
                        }
                    }
                    Debug.Log("eating down");
                    if (currentLvlData[(int)transform.position.x + ((int)Mathf.Abs(transform.position.y) + 1) * gridHandler.gridWidth] == 4)
                    {
                        uiData.AddCandyIAte();
                    }

                    currentLvlData[(int)transform.position.x + ((int)Mathf.Abs(transform.position.y) + 1) * gridHandler.gridWidth] = 6;
                }
            }
            else if (Input.GetKey("d") || Input.GetKey("right"))
            {
                if (currentLvlData[(int)transform.position.x + 1 + ((int)Mathf.Abs(transform.position.y)) * gridHandler.gridWidth] == 7)
                {
                    if (uiData.candyIAte >= uiData.candyINeed)
                    {
                        Debug.Log("game completed");
                        toggleEndScreen.Toggle(true);
                    }
                }
                print("going right");
                if (currentLvlData[(int)transform.position.x + 1 + ((int)Mathf.Abs(transform.position.y)) * gridHandler.gridWidth] == 6 || currentLvlData[(int)transform.position.x + 1 + ((int)Mathf.Abs(transform.position.y)) * gridHandler.gridWidth] == 0 || currentLvlData[(int)transform.position.x + 1 + ((int)Mathf.Abs(transform.position.y)) * gridHandler.gridWidth] == 4)
                {

                    if (currentLvlData[(int)transform.position.x + 1 + ((int)Mathf.Abs(transform.position.y)) * gridHandler.gridWidth] == 4)
                    {
                        uiData.AddCandyIAte();
                    }
                    currentLvlData[(int)transform.position.x + 1 + ((int)Mathf.Abs(transform.position.y)) * gridHandler.gridWidth] = myType;
                    currentLvlData[(int)transform.position.x + ((int)Mathf.Abs(transform.position.y)) * gridHandler.gridWidth] = 6;
                    transform.Translate(new Vector2(1, 0));
                    Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, 0.1f);
                    if (colliders.Length > 0)
                    {
                        foreach (var item in colliders)
                        {
                            Destroy(item.gameObject);
                        }
                    }
                    if (transform.position.x - 1 < gridHandler.gridWidth - 8 && transform.position.x - 1 > 8)
                    {
                        mainCamera.transform.Translate(new Vector2(1, 0));
                    }
                }
            }
            else if (Input.GetKey("a") || Input.GetKey("left"))
            {
                if (currentLvlData[(int)transform.position.x - 1 + ((int)Mathf.Abs(transform.position.y)) * gridHandler.gridWidth] == 7)
                {
                    if (uiData.candyIAte >= uiData.candyINeed)
                    {
                        Debug.Log("game completed");
                        toggleEndScreen.Toggle(true);
                    }
                }
                print("going left");
                if (currentLvlData[(int)transform.position.x - 1 + ((int)Mathf.Abs(transform.position.y)) * gridHandler.gridWidth] == 6 || currentLvlData[(int)transform.position.x - 1 + ((int)Mathf.Abs(transform.position.y)) * gridHandler.gridWidth] == 0 || currentLvlData[(int)transform.position.x - 1 + ((int)Mathf.Abs(transform.position.y)) * gridHandler.gridWidth] == 4)
                {

                    if (currentLvlData[(int)transform.position.x - 1 + ((int)Mathf.Abs(transform.position.y)) * gridHandler.gridWidth] == 4)
                    {
                        uiData.AddCandyIAte();
                    }
                    currentLvlData[(int)transform.position.x - 1 + ((int)Mathf.Abs(transform.position.y)) * gridHandler.gridWidth] = myType;
                    currentLvlData[(int)transform.position.x + ((int)Mathf.Abs(transform.position.y)) * gridHandler.gridWidth] = 6;
                    transform.Translate(new Vector2(-1, 0));
                    Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, 0.1f);
                    if (colliders.Length > 0)
                    {
                        foreach (var item in colliders)
                        {
                            Destroy(item.gameObject);
                        }
                    }
                    if (transform.position.x + 1 < gridHandler.gridWidth - 7 && transform.position.x + 1 > 9)
                    {
                        mainCamera.transform.Translate(new Vector2(-1, 0));
                    }
                }
            }
            else if (Input.GetKey("w") || Input.GetKey("up"))
            {
                if (currentLvlData[(int)transform.position.x + ((int)Mathf.Abs(transform.position.y) - 1) * gridHandler.gridWidth] == 7)
                {
                    if (uiData.candyIAte >= uiData.candyINeed)
                    {
                        Debug.Log("game completed");
                        toggleEndScreen.Toggle(true);
                    }
                }
                print("going up");
                if (currentLvlData[(int)transform.position.x + ((int)Mathf.Abs(transform.position.y) - 1) * gridHandler.gridWidth] == 6 || currentLvlData[(int)transform.position.x + ((int)Mathf.Abs(transform.position.y) - 1) * gridHandler.gridWidth] == 0 || currentLvlData[(int)transform.position.x + ((int)Mathf.Abs(transform.position.y) - 1) * gridHandler.gridWidth] == 4)
                {

                    if (currentLvlData[(int)transform.position.x + ((int)Mathf.Abs(transform.position.y) - 1) * gridHandler.gridWidth] == 4)
                    {
                        uiData.AddCandyIAte();
                    }
                    currentLvlData[(int)transform.position.x + ((int)Mathf.Abs(transform.position.y) - 1) * gridHandler.gridWidth] = myType;
                    currentLvlData[(int)transform.position.x + ((int)Mathf.Abs(transform.position.y)) * gridHandler.gridWidth] = 6;
                    transform.Translate(new Vector2(0, +1));
                    Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, 0.1f);
                    if (colliders.Length > 0)
                    {
                        foreach (var item in colliders)
                        {
                            Destroy(item.gameObject);
                        }
                    }
                    if (transform.position.y - 1 < -4 && transform.position.y - 1 > -(currentLvlData.Count / gridHandler.gridWidth - 3))
                    {
                        mainCamera.transform.Translate(new Vector2(0, 1));
                    }
                }
            }
            else if (Input.GetKey("s") || Input.GetKey("down"))
            {
                if (currentLvlData[(int)transform.position.x + ((int)Mathf.Abs(transform.position.y) + 1) * gridHandler.gridWidth] == 7)
                {
                    if (uiData.candyIAte >= uiData.candyINeed)
                    {
                        Debug.Log("game completed"); if (currentLvlData[(int)transform.position.x + ((int)Mathf.Abs(transform.position.y) + 1) * gridHandler.gridWidth] == 7)
                        {
                            if (uiData.candyIAte >= uiData.candyINeed)
                            {
                                Debug.Log("game completed");
                                toggleEndScreen.Toggle(true);
                            }
                        }
                    }
                }
                if (currentLvlData[(int)transform.position.x + ((int)Mathf.Abs(transform.position.y) + 1) * gridHandler.gridWidth] == 6 || currentLvlData[(int)transform.position.x + ((int)Mathf.Abs(transform.position.y) + 1) * gridHandler.gridWidth] == 0 || currentLvlData[(int)transform.position.x + ((int)Mathf.Abs(transform.position.y) + 1) * gridHandler.gridWidth] == 4)
                {
                    if (currentLvlData[(int)transform.position.x + ((int)Mathf.Abs(transform.position.y) + 1) * gridHandler.gridWidth] == 4)
                    {
                        uiData.AddCandyIAte();
                    }
                    currentLvlData[(int)transform.position.x + ((int)Mathf.Abs(transform.position.y) + 1) * gridHandler.gridWidth] = myType;
                    currentLvlData[(int)transform.position.x + ((int)Mathf.Abs(transform.position.y)) * gridHandler.gridWidth] = 6;
                    transform.Translate(new Vector2(0, -1));
                    Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, 0.1f);
                    if (colliders.Length > 0)
                    {
                        foreach (var item in colliders)
                        {
                            Destroy(item.gameObject);
                        }
                    }
                    if (transform.position.y + 1 < -3 && transform.position.y + 1 > -(currentLvlData.Count / gridHandler.gridWidth - 4))
                    {
                        mainCamera.transform.Translate(new Vector2(0, -1));
                    }
                }
            }
        }
        if (Input.GetKey("r"))
        {
            RestartGame();
        }
    }

    public void Explode()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, 1f);
        if (colliders.Length > 0)
        {
            foreach (var item in colliders)
            {
                Destroy(item.gameObject);
            }
        }
        for (int i = 0; i < 9; i++)
        {
            Instantiate(explosion, new Vector3(transform.position.x + (i % 3) - 1, transform.position.y - (Mathf.Floor(i / 3)) + 1, transform.position.z), transform.rotation);
        }

        Destroy(this.gameObject);
    }

    void RestartGame()
    {
        GameObject.FindGameObjectWithTag("RelaodLvlObject").GetComponent<ReloadLevel>().ReloadDelay();
    }
}
