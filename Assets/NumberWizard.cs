﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {

	// Use this for initialization
	int max;
	int min;
	int guess;

    int maxGuessesAllowed = 10;

    public Text text;

	void Start () {
		StartGame ();	
	}
	
	void StartGame () {
		max = 1000;
		min = 1;
        NextGuess();
	
		max = max + 1;
        text.text = "Is your number " + guess.ToString() + "?";
	}
	
	void NextGuess () {
		guess = Random.Range(min, max+1);
        text.text = "Is your number " + guess.ToString() + "?";
        maxGuessesAllowed = maxGuessesAllowed - 1;
        if (maxGuessesAllowed <= 0){
            Application.LoadLevel("Win");
        }
		
	}
	
    public void GuessHigher() {
        min = guess;
        NextGuess();

    }

    public void GuessLower() {
        max = guess;
        NextGuess();
}

   
    
}
