using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
    
{
    public bool isUsed = false;
    private GameController gameController;


    // Start is called before the first frame update
    void Start()
    {
        gameController = FindObjectOfType<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake()
    {
        gameController.distractions++;
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
        gameController.distractions--;
        isUsed = false;
        gameObject.SetActive(false);

    }
}
