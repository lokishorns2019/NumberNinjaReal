using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bodyFollow : MonoBehaviour
{
    public float speed = 3f;
    public float turnSpeed = 3f;
    public float distance;
    public GameObject target;
    private SpriteRenderer mySpriteRenderer;

    // This function is called just one time by Unity the moment the component loads
    private void Awake()
    {
        // get a reference to the SpriteRenderer component on this gameObject
        mySpriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {

        Vector2 direction = target.transform.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, turnSpeed * Time.deltaTime);

        
        float dist = Vector2.Distance(target.transform.position, transform.position);
        if (dist > distance + 1)
        {

                transform.position = Vector2.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);
            
        }

      
    }
}
