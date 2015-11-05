﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LvlData : MonoBehaviour {

    public List<int> lvl1;
    public int lvl1Width = 40;
    public int lvl1candyNeeded = 15;
    public int lvl1Time = 200;

    void Awake()
    {
        lvl1 = new List<int> {              1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,
                                            1,0,0,0,0,0,0,6,0,0,4,0,3,6,0,0,0,0,0,3,0,3,0,0,0,0,0,0,0,6,0,0,0,0,3,0,0,0,0,1,
                                            1,0,3,5,3,0,0,0,0,0,0,6,0,0,0,0,0,0,0,0,0,3,4,0,0,3,0,0,0,0,6,0,0,0,0,0,0,0,0,1,
                                            1,0,0,0,0,0,0,0,0,0,0,6,0,0,3,0,0,0,0,0,3,0,3,0,0,3,0,0,0,0,0,0,0,0,3,0,0,0,0,1,
                                            1,3,0,3,3,0,0,0,0,0,0,0,0,0,3,0,0,0,0,0,0,3,0,0,3,0,0,0,0,3,0,0,0,3,0,0,0,0,0,1,
                                            1,3,0,6,3,0,0,0,0,0,0,0,0,0,6,3,0,0,3,0,0,0,0,0,0,0,0,3,0,0,0,0,0,0,3,0,3,3,0,1,
                                            1,0,0,0,6,0,0,3,0,0,0,0,0,0,0,0,3,0,0,0,0,0,3,0,6,3,0,0,0,0,0,0,0,0,3,0,3,3,0,1,
                                            1,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,0,0,0,3,0,0,3,0,1,
                                            1,0,6,0,0,0,3,0,0,4,6,0,0,3,6,3,0,0,0,0,0,0,0,0,0,0,0,4,0,3,4,0,0,0,0,0,0,6,0,1,
                                            1,0,0,4,0,0,0,0,0,3,0,0,0,0,0,0,0,0,0,0,0,0,0,3,3,3,6,3,0,0,3,0,0,0,0,0,0,0,0,1,
                                            1,0,0,0,3,0,0,3,0,3,0,0,0,0,0,0,0,0,0,0,0,0,0,3,6,0,0,3,0,0,3,0,0,0,0,0,0,0,0,1,
                                            1,0,3,0,0,0,0,0,3,0,0,0,0,0,0,0,3,3,3,0,0,0,0,0,0,0,0,3,0,0,6,0,4,0,0,0,0,3,0,1,
                                            1,0,4,0,0,6,0,0,3,0,6,6,0,0,0,0,3,0,3,4,0,0,4,0,0,0,0,0,0,0,0,0,3,0,0,4,0,6,0,1,
                                            1,0,6,0,0,0,0,0,0,0,0,0,0,0,0,0,0,3,6,3,0,0,3,0,0,0,0,0,0,0,0,0,4,0,0,0,0,0,3,1,
                                            1,0,0,0,0,0,0,0,0,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,1,
                                            1,6,3,0,0,0,0,0,0,0,0,0,3,0,0,0,4,0,0,0,0,3,0,0,0,0,0,3,0,0,0,3,0,0,0,0,0,0,0,1,
                                            1,6,3,0,0,0,0,0,0,0,0,0,6,3,0,0,3,0,0,0,0,0,0,0,0,3,0,0,0,0,0,0,3,0,3,3,0,0,0,1,
                                            1,0,6,0,0,3,0,0,0,0,0,0,0,0,3,0,0,0,0,0,3,0,6,6,0,0,0,0,4,0,0,0,3,0,3,3,0,0,7,1,
                                            1,0,0,0,0,3,4,0,0,3,0,0,0,0,0,0,0,0,3,0,0,0,0,0,0,3,0,3,4,0,0,0,0,0,0,3,0,0,0,1,
                                            1,0,0,0,6,0,0,3,0,6,0,0,3,0,3,3,0,0,0,0,0,0,0,0,0,3,0,3,4,0,0,0,0,0,0,6,0,0,3,1,
                                            1,0,4,0,0,0,0,6,0,0,0,0,0,6,0,0,0,0,0,0,0,0,0,6,0,3,0,0,3,0,0,0,0,3,0,0,0,3,0,1,
                                            1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1};
    }
    void Start()
    {
        Debug.Log(lvl1.Count / lvl1Width);
    }
}