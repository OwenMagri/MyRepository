using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

    public Text myText;
    public InputField myField;
    int num1 = 0;
    int num2 = 0;

    System.Random rand = new System.Random(); //The Random class found in the System library
    Random unityRand = new Random(); //the Random class found in the UnityEngine library

	// Use this for initialization
	void Start () {

        StartGame();
    }

    // Update is called once per frame
    void Update() {
        
    }

    public void GetAnswer()
    {
        int multiplicationAns = num1 * num2;

        int userAnswer = 0;
        userAnswer = System.Convert.ToInt32(myField.text); //read(get) - fetching the text

        if(userAnswer == multiplicationAns)
        {
            print("Correct answer!");
            StartGame();
        }
        else
        {
            print("Incorrect answer!");
        }
    }

    void StartGame()
    {
        myField.text = "";
        num1 = rand.Next(1, 11);
        num2 = Random.Range(1, 11);


        myText.text = "What is " + num1 + " x " + num2 + "?"; //write(set) - changing the text
    }
}
