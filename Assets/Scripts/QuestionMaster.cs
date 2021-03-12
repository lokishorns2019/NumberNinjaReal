using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.Random;

public class QuestionMaster : MonoBehaviour {

    //varibles for question display
    public int numberA = 0;
    public int numberB = 0;
    public int sum = 0;
    public int totalCorrect = 0;
    public int totalQuestions = 0;



    //game object variables
    public string input = " ";
    public GameObject inputField;
    public InputField yourInputField;
    public Text textDisplay;

    public GameObject gameOver;
    public GameObject questionScreen;
    public GameObject win;
    public GameObject pause;
    private bool trigger = false;

    public void inputNum()
    {
        input = inputField.GetComponent<Text>().text;
        
        if (input.Equals(sum.ToString()) == true)
        {
            //access time set normal 
            Time.timeScale = 1f;
            questionScreen.SetActive(false);
            //tally correct answer
            totalCorrect++;
            trigger = false;
        }
        else
        {
            //     //have dragon eat cha-boy
            //turn off controls for user
            questionScreen.SetActive(false);
            gameOver.SetActive(true);

        }

        //increment questions
        totalQuestions++;
    }

    public void displayQuestion() 
    {
        textDisplay.text = numberA.ToString() + " + " + numberB.ToString();
        
    }

    public void Update()
    {
        if (Time.timeScale == 0f && trigger == false && gameOver.active == false && win.active == false && pause.active == false)
        {

            GenerateQuestions();
            questionScreen.SetActive(true);
            trigger = true;
            yourInputField.ActivateInputField();
            yourInputField.text = "";

        }
        if ((Input.GetKeyDown("enter") || Input.GetKey("return")) && questionScreen.active == true)
        {
            inputNum();
        }

    }
        
    void GenerateQuestions() {

        //randomizing numbers to be summed from 1-9
        int nA = UnityEngine.Random.Range(1, 9);
        int nB = UnityEngine.Random.Range(1, 9);

        numberA = nA;
        numberB = nB;

        //summing the numbers for correct answer 
        //ready for input from user
        sum = numberA + numberB;

        //later add subtraction 


        //display question
        displayQuestion();
    }


} 
        
    