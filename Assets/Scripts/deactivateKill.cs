using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deactivateKill : MonoBehaviour
{

    public GameObject killzone;
    public GameObject ch;
    // Update is called once per frame
    void Update()
    {
        if(ch.active == true)
        {
            killzone.SetActive(false);
        }
    }
}
