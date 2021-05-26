using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{
    
    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] TextMeshProUGUI guessText;
    int guess;

    // Use this for initialization
    void Start ()
    {
        StartGame();
	}
	
    void StartGame()
    {
        NextGuess();
        max = max + 1;
    }

    public void OnPressHigher(){
        min = guess + 1;
        NextGuess();

    }
    public void OnPressLower(){
        max = guess - 1;
        NextGuess();
    }

    void NextGuess()
    {
        // guess = (max + min) / 2;
        guess = Random.Range(min, max + 1);
        //display text
        guessText.text = guess.ToString();//we use ToString() method to convert to string
    }
}
