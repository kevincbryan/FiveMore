using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
    
{
    public bool isUsed = false;
    private GameController gameController;
    public TimedDistraction timer;
    public AudioSource annoyingSound;


    // Start is called before the first frame update
    void Start()
    {
        gameController = FindObjectOfType<GameController>();

      
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable()
    {
        gameController = FindObjectOfType<GameController>();     
        gameController.distractions++;
        annoyingSound.Play();
    }

    private void OnDisable()
    {
        //gameController.distractions--;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (isUsed == false)
        {
            if (collision.tag == "PlayerTouch")
            {
                isUsed = true;
                TurnOff();
            }
        }
    }

    private void TurnOff()
    {
        gameController.distractions--;
        annoyingSound.Stop();
        timer.ResetObject();
        isUsed = false;
        gameObject.SetActive(false);

    }
}
