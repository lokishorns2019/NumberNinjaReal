using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bodyFollow : MonoBehaviour
{
    public float speed = 3f;
    public float distance;
    public GameObject target;
    //public string tagThing;
    /*
    void Start()
    {
        target.transform.position = GameObject.FindGameObjectWithTag(tagThing).GetComponent<Transform>();
    }*/

    void Update()
    {
        float dist = Vector2.Distance(target.transform.position, transform.position);
        if (dist > distance + 1)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);
        }
    }
}
