using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{
    // They are up here so they can be accessed in the Start() method and Update() method
    // int means its a number
    [SerializeField] int max;
    [SerializeField] int min;
    // This is to grab the TextMeshPROUGUI in Guess Number Text in Core Scene
    [SerializeField] TextMeshProUGUI guessText;
    int guess;


    // Start is called before the first frame update
    // void Start used for initilization. 
    void Start()
    {
        StartGame();
    }

    // void means there is no return value. Nothing is returned
    void StartGame()
    {
        guess = (max + min) / 2;
        // Here we are accessing the "???" and setting it to guess, but have to convert it to a string since it is being displayed as a string in the scene.
        guessText.text = guess.ToString();
        max = max + 1;
    }

    public void onPressHigher()
    {
        min = guess;

        NextGuess();
    }

    public void OnPressLower()
    {
        max = guess;
        NextGuess();
    }
    
    void NextGuess()
    {
        guess = (max + min) / 2;
        guessText.text = guess.ToString();

    }
}
