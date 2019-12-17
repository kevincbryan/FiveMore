using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public float sleepValue;
    private float minSleepValue = 0f;
    private float maxSleepValue = 100f;

    public int distractions = 0;
    private int minDistractions = 0;
    private int maxDistractions = 7;
    public float sleepRate = 1f;
    private int sleepCapacity = 3;


    // Start is called before the first frame update
    void Start()
    {
        sleepValue = minSleepValue;
        distractions = minDistractions;
    }

    // Update is called once per frame
    void Update()
    {
        sleepValue += (sleepCapacity - distractions) * sleepRate * Time.deltaTime;
        //Debug.Log("Sleep Value is " + sleepValue);

        if (sleepValue < minSleepValue)
        {
            sleepValue = minSleepValue;
        }
        else if (sleepValue > maxSleepValue)
        {
            sleepValue = maxSleepValue;
        }

        if (distractions < 0)
        {
            distractions = 0;
            Debug.Log("Distractions was lower than 0, something has gone wrong");
        }
      
       
    }

   
      
}
