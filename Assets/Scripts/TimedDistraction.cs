﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedDistraction : MonoBehaviour
{
    public bool isRandom = false;
    public bool isRepeating = false;
    public GameObject interactable;
    public float minTime;
    public float maxTime;
    private float time;

    private float timeUntilFire = 0f;
    private bool runOnce = false;

    // Start is called before the first frame update
    void Start()
    {
        time = maxTime;
        if (minTime < 0)
        {
            minTime = 0;
        }

        if (isRandom == true)
        {
            time = Random.Range(minTime, maxTime);
        }
    }

    // Update is called once per frame
    void Update()
    {
        timeUntilFire += Time.deltaTime;
        //Debug.Log("Time is " + timeUntilFire);
        if (timeUntilFire >= time)
        {
            if (runOnce == false)
            {
                runOnce = true;
                interactable.SetActive(true);
            }
        }
    }
}