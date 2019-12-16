using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceRooms : MonoBehaviour
{

    public GameObject[] rooms;
    public GameObject[] roomLocs;
    //private GameObject[] roomsPicked;
    // Start is called before the first frame update
    void Start()
    {
        ShuffleArray();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void ShuffleArray()
    {
        int n = rooms.Length;

        while ( n > 1)
        {
            n--;
            int k = Random.Range(1, 0 + 1);


        }

    }
}
