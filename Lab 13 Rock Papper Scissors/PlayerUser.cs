using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_13_Rock_Papper_Scissors
{
    class PlayerUser : Player
    {
        public string User { get; set; }

        public PlayerUser(string playerName) 
        {
            User = playerName;
        }
        public PlayerUser()
        {

        }
        //public static string PlayerName(string message)
        //{
        //    Console.Write("What's your name, or should I call you newbie?: \n");
        //    message = Console.ReadLine();
        //    Console.WriteLine($"\n\n{message}");
        //    return message;
        //}

        public override Roshambo GenerateRoshambo()
        {
            Console.WriteLine("\nRock, Paper, Scoissors?: (\"r\"/\"p\"/\"s\")");
           string  message = Console.ReadLine();
            if (message == "r")
            {
                return Roshambo.rock;
            }
            else if (message == "p")
            {
                return Roshambo.paper;
            }
            else if (message == "s")
            {
                return Roshambo.scissors;
            }
            else
            {
                Console.WriteLine("\nThat was not a valid choice, try again.\n");
                return GenerateRoshambo();
            }
        }

 
    }
}
