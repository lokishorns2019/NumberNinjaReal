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
    public GameObject textDisplay;

    public void displayQuestion() 
    {
        textDisplay.GetComponent<Text>().text = numberA.ToString() + " + " + numberB.ToString();
    }

    
    private void GenerateQuestions() {

        //randomizing numbers to be summed from 1-9
        int nA = UnityEngine.Random.Range(1, 9);
        int nB = UnityEngine.Random.Range(1, 9);

        numberA = nA;
        numberB = nB;

        //summing the numbers for correct answer 
        //ready for input from user
        sum = numberA + numberB;

        //later add subtraction 

        while (Time.timeScale == 0f) {
            //display question
            displayQuestion();
            input = inputField.GetComponent<Text>().text;
            int answer = Int16.Parse(input);
            if(answer == sum) {
                //access time set normal 
                Time.timeScale = 1f;
                
                //tally correct answer
                totalCorrect++;
                break;
            } else {
                //have dragon eat cha-boy
                //turn off controls for user
            }

            //increment questions
            totalQuestions++;
        }

        
    } // end of GenerateQuestions

}