using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour   
{
    //Game data configuration
    string[] levelOnePasswords = { "cat", "joy", "dog", "bed", "pink" };
    string[] levelTwoPasswords = { "education", "class", "sports", "grade", "lunch" };

    //This is the game state
    int level;
    enum Screen {MainMenu, Password, WinMenu};
    Screen currentScreen;
    //const string EASYPASS = "cat";
    //const string HARDPASS = "class";
    string password;

    // Start is called before the first frame update
    void Start()
    {
        ShowMainMenu();
    }

    void ShowMainMenu()
    {
        currentScreen = Screen.MainMenu;
        Terminal.ClearScreen();
        Terminal.WriteLine("What's up user!");
        Terminal.WriteLine("Feel like committing a crime today?");
        Terminal.WriteLine("That's cool, no judgement here.");
        Terminal.WriteLine("What do you want to hack into?");
        //Terminal.WriteLine("Be aware that the difficulty increases the higher you go!");
        Terminal.WriteLine("\n");
        Terminal.WriteLine("Press 1 for your friend's laptop");
        Terminal.WriteLine("2 for your school records");
        Terminal.WriteLine("3 for your FBI agent");
        Terminal.WriteLine("Enter your decision");
    }

    void OnUserInput(string input)
    {
        if(input == "menu")
        {
            ShowMainMenu();
        }
        else if(currentScreen == Screen.MainMenu)
        {
            RunMainMenu(input);
        }
        else if(currentScreen == Screen.Password)
        {
            CheckPassword(input);
        }
    }

    void RunMainMenu(string input)
    {
        bool isValidLevelNumber = (input == "1" || input == "2" || input == "3");
        if (isValidLevelNumber)
        {
            level = int.Parse(input);
            StartGame();
        }
        else if (input == "69")  //easter egg
        {
            Terminal.WriteLine("Not enough money for chicken nuggets");
            Terminal.WriteLine("Choose again");
        }
        else if (input == "Kingdom Hearts")  //easter egg
        {
            Terminal.WriteLine("Fun game. Not the one we're playing" + "\n" + "though");
            Terminal.WriteLine("Choose again");
        }
        else
        {
            Terminal.WriteLine("That is not a valid option");
            Terminal.WriteLine("Choose again");
        }
    }

    void StartGame()
    {
        currentScreen = Screen.Password;
        Terminal.ClearScreen();
        switch (level)
        {
            case 1:
                password = levelOnePasswords[Random.Range(0, levelOnePasswords.Length)];
                break;
            case 2:
                password = levelTwoPasswords[Random.Range(0, levelTwoPasswords.Length)];
                break;
            default:
                Debug.LogError("Invalid Level Number");
                break;
        }
        Terminal.WriteLine("Please enter the password:");
    }

    void CheckPassword(string input)
    {
        if(input == password)
        {
            DisplayWinScreen();
        }
        else
        {
            Terminal.WriteLine("WRONG! Please try again.");
        }
    }

    void DisplayWinScreen()
    {
        currentScreen = Screen.WinMenu;
        Terminal.ClearScreen();
        ShowLevelReward();
    }

    void ShowLevelReward()
    {
        switch (level)
        {
            case 1:
                Terminal.WriteLine("Going snooping are you?");
                Terminal.WriteLine(@"
Draw eyes here later

"
                );
                break;
        }
    }

    void CheckHardPassword(string input)
    {
        if (input == password)
        {
            Terminal.WriteLine("You got it right!");
        }
        else
        {
            Terminal.WriteLine("WRONG! Please try again.");
        }
    }

}
