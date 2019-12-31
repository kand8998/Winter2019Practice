using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    //Initial Script Based on a Tutorial
    public GameAction startAction, nextAction;
    
    private int max;
    private int min;
    private int guess;
    
    private void Start()
    {
        startAction.action += StartGame;
        startAction.Raise();
        nextAction.action += NextGuess;
    }

    private void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;
        Debug.Log("Welcome to number wizard");
        Debug.Log("Pick a number, don't tell me what it is...");
        Debug.Log("The highest number you can pick is: " + max);
        Debug.Log("The lowest number you can pick is: " + min);
        Debug.Log("Tell me if your number is higher or lower than:" + guess);
        Debug.Log("Push Up = Higher, Push Down = Lower, Push Enter = Correct");
        max += 1;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            nextAction.Raise();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            nextAction.Raise();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("I am a genius!");
            startAction.Raise();
        }
    }

    private void NextGuess()
    {
        guess = (max + min) / 2;
        Debug.Log("It is higher or lower than..." + guess);
    }
}
