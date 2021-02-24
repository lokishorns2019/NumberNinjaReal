using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIDamage : MonoBehaviour
{
    public Animator anim;
    public GameObject ch;
    public Collider2D thing;


    void Start()
    {
        anim = GetComponent<Animator>();
    }



    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other == thing)
        {
            if (anim != null)
            {
                anim.Play("death");
            }
            Time.timeScale = 0.05f;
            ch.SetActive(true);
        }
    }
}
