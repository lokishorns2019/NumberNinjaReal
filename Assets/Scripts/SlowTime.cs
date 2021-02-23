using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowTime : MonoBehaviour
{
    public float time = 0f;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Time.timeScale = time;
    }
}
