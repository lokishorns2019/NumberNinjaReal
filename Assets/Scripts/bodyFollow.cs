using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bodyFollow : MonoBehaviour
{
    public float speed = 3f;
    public float turnSpeed = 3f;
    public float distance = 25f;
    public float sprintSpeed = 6f;
    public float size = 1f;
    public GameObject thingToFollow;
    private Transform target;

    void Start()
    {
        target = thingToFollow.GetComponent<Transform>();
    }

    void Update()
    {
        Vector2 direction = target.transform.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, turnSpeed * Time.deltaTime);

        if (direction.x > 0)
        {
            transform.localScale = new Vector3(size, size, size);
        }
        else if (direction.x < 0)
        {
            transform.localScale = new Vector3(size, -size, size);
        }

        float dist = Vector2.Distance(target.transform.position, transform.position);
        if (dist > 1 && dist < distance)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

        }
        else if (dist > distance)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, sprintSpeed * Time.deltaTime);
        }

    }
}