using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIFollow : MonoBehaviour
{
    public float speed = 3f;
    public float distance = 25f;
    public float sprintSpeed = 6f;
    public float turnSpeed = 3f;
    public float size = 1f;
    private Transform target;
    public bool isSpeedyBoi = false;
    

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    void Update()
    {
        Vector2 direction = target.transform.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, turnSpeed * Time.deltaTime);


        float dist = Vector2.Distance(target.transform.position, transform.position);
        if ((dist > 0 && dist < distance)){
            isSpeedyBoi = false;
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
            if (direction.x > 0)
            {
                transform.localScale = new Vector3(size, size, size);
            }
            else if (direction.x < 0)
            {
                transform.localScale = new Vector3(-size, size, size);
            }
        }
        else if(dist > distance){
            isSpeedyBoi = true;
            transform.position = Vector2.MoveTowards(transform.position, target.position, sprintSpeed * Time.deltaTime);
            if (direction.x > 0)
            {
                transform.localScale = new Vector3(size, size, size);
            }
            else if (direction.x < 0)
            {
                transform.localScale = new Vector3(-size, size, size);
            }
        }

        if(Mathf.Abs(angle) > 90 && Mathf.Abs(angle) < 270)
        {
            transform.localScale = new Vector3(size, -size, size);
        }
        else
        {
            transform.localScale = new Vector3(size, size, size);
        }
        

    }
}
