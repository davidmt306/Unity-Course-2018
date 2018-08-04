using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {
    int max;
    int min;
    int guess;

    // Use this for initialization
    void Start () {
        StartGame();
	}

    void StartGame () {
        max = 1000;
        min = 1;
        guess = 500;
        Debug.Log("Welcome to number wizard");
        Debug.Log("Pick a number, don't tell me what it is");
        Debug.Log("Highest number is: " + max);
        Debug.Log("Lowest number is: " + min);
        Debug.Log("Lower or higher than " + guess + "?");
        Debug.Log("UP = Higher, DOWN = Lower, ENTER = Correct!");
        max = max + 1;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            min = guess;
            NextGuess();
        } else if (Input.GetKeyDown(KeyCode.DownArrow)) {
            max = guess;
            NextGuess();
        } else if (Input.GetKeyDown(KeyCode.Return)) {
            Debug.Log("I won!");
            StartGame();
        }
    }

    void NextGuess () {
        guess = (max + min) / 2;
        Debug.Log("Higher or lower than: " + guess + "?");
    }
}
