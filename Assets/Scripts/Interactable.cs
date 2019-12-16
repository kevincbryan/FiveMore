using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
    
{
    public bool isUsed = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (isUsed == false)
        {
            if (collision.tag == "Player")
            {
                isUsed = true;
            }
        }
    }
}
