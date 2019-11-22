using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ShowMainMenu();
    }

    void ShowMainMenu()
    {
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
        else if(input == "1")
        {
            Terminal.WriteLine("You chose friend's laptop!");
        }
        else if (input == "2")
        {
            Terminal.WriteLine("You chose school records");
        }
        else if (input == "3")
        {
            Terminal.WriteLine("You chose FBI agent!");
        }
        else if (input == "69")
        {
            Terminal.WriteLine("Not enough money for chicken nuggets");
            Terminal.WriteLine("Choose again");
        }
        else if (input == "Kingdom Hearts")
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
}
