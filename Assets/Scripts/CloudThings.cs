using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudThings : MonoBehaviour
{

    public GameObject player;


    private void OnTriggerEnter2D(Collider2D other)
    {
        //do something cool idk yet
        Time.timeScale = 0f;
    }
}
