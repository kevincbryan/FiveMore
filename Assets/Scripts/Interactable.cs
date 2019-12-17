using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
    
{
    public bool isUsed = false;
    private GameController gameController;
    public TimedDistraction timer;


    // Start is called before the first frame update
    void Start()
    {
        gameController = FindObjectOfType<GameController>();

        if (gameController)
        {
            Debug.Log("Game Controller Found");
        }
        else
        {
            Debug.Log("Game Controller Not FOund");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable()
    {
        gameController = FindObjectOfType<GameController>();
        if (gameController)
        {
            Debug.Log("Game Controller Found");
        }
        else
        {
            Debug.Log("Game Controller Not FOund");
        }
        gameController.distractions++;
    }

    private void OnDisable()
    {
        gameController.distractions--;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (isUsed == false)
        {
            if (collision.tag == "Player")
            {
                isUsed = true;
                TurnOff();
            }
        }
    }

    private void TurnOff()
    {
        //gameController.distractions--;
        timer.ResetObject();
        isUsed = false;
        gameObject.SetActive(false);

    }
}
