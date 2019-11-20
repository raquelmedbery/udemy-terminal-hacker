using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Terminal.WriteLine("What's up?");
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

    // Update is called once per frame
    void Update()
    {
        
    }
}
