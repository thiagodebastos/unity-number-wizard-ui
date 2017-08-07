using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour
{
    // initialise variables
    int min;
    int max;
    int guess;
    public int maxGuessesAllowed = 5;

    public Text text;

    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        min = 1;
        max = 1000;
        NextGuess();
    }

    public void GuessHigher()
    {
        // add 1 to make sure we can guess up to 1000
        min = guess;
        NextGuess();
    }

    public void GuessLower()
    {
        max = guess;
        NextGuess();
    }

    void NextGuess()
    {
        // add one to max as Random.Range returns a value exclusive of max
        guess = Random.Range(min, max + 1);
        text.text = guess.ToString();
        maxGuessesAllowed -= 1;
        if (maxGuessesAllowed <= 0)
            SceneManager.LoadScene("Win");
    }
}
