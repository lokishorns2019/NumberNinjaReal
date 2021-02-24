using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    public Animator anim;
    public GameObject ch;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (anim != null)
            {
                anim.Play("death");
            }
            Time.timeScale = .05f;
            ch.SetActive(true);
        }
    }
}
