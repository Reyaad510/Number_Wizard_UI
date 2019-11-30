using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    // They are up here so they can be accessed in the Start() method and Update() method
    // int means its a number
    [SerializeField] int max;
    [SerializeField] int min;
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
        max = max + 1;
        guess = (max + min) / 2;
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
       
    }
}
