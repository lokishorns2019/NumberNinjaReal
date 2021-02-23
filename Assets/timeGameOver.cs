using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class timeGameOver : MonoBehaviour
{
    /*// Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0f; 
    }*/

    public void RestartGame()
    {
        SceneManager.LoadScene("MainLevel");
    }

    public void QuitGame()
    {
        Debug.Log("QUIT!!");
        Application.Quit();
    }

}
