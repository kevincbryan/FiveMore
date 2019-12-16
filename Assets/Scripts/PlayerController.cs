using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float playerSpeed = 10f;
    public bool isMoving = false;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Debug.Log("PlayerController is running");
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetAxis ("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
        {
            isMoving = true;
            Debug.Log("getting Input " + Input.GetAxis ("Horizontal") + Input.GetAxis ("Vertical"));
            Move();
        }
        else
        {
            Debug.Log("No input");
            isMoving = false;
        }
    }

    private void Move()
    {
        
        float moveRight = 0;
        float moveForward = 0;

        moveForward += Input.GetAxis("Vertical");
        moveRight += Input.GetAxis("Horizontal");

        Vector3 moveVector  = ((transform.forward * moveForward) + (transform.right * moveRight));

        moveVector.Normalize();
        moveVector *= playerSpeed * Time.deltaTime;
        transform.position += moveVector;
    }
}
