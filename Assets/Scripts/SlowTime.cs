﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowTime : MonoBehaviour
{
    public float time = 0f;

    private void OnTriggerEnter2D(Collider2D other)
    {
        //first we make sure that the object that hit the banana is the player.
        //if (other.name == "Player")
        //{
            // This will search all player scripts for a function called "Hit Banana"
            Time.timeScale = time; 
        //}
    }
}