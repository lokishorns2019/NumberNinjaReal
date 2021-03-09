using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class bodyFollow : MonoBehaviour
{
    public float distdos = 0f;
    public float speed = 3f;
    public float distance = 1f;
    public float sprintSpeed = 6f;
    public GameObject previousNode;
    public float size = 1f;
    private Transform target;
    AIFollow follower;

    void Start()
    {
        target = previousNode.GetComponent<Transform>();
        follower = new AIFollow();
    }

    void Update()
    {

        if(GameObject.Find("DragonHead").GetComponent<AIFollow>().isSpeedyBoi == true)
        {
            speed = 12f;
        }
        else
        {
            speed = 6f;
        }

        Vector2 direction = target.transform.position - transform.position;



        float dist = Vector2.Distance(target.transform.position, transform.position);
        if (dist < distdos && dist > .3)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed / 2 * Time.deltaTime);
        }
        else if (dist > distdos && dist < distance)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
            if (direction.x < 0)
            {
                transform.localScale = new Vector3(size, size, size);
            }
            else if (direction.x > 0)
            {
                transform.localScale = new Vector3(-size, size, size);
            }

        }
    }
}