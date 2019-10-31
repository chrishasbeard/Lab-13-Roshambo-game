using System;

namespace Lab_13_Rock_Papper_Scissors
{
    class Program
    {
        static PlayerRandom WildCard = new PlayerRandom();
        static PlayerRock Rocky = new PlayerRock();
        static PlayerUser User;
        static string playerName = string.Empty;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome, welcome! You know the rules, two players enter, and two leave. \n\nThe Highsteaks games are down the hall. . . \n");
            Console.Write("What's your name, or should I call you newbie?: \n");
            string playerName = Console.ReadLine();
            //Console.WriteLine($"\n\n{playerName}");
            User = new PlayerUser(playerName);

            do
            {
                ChooseYourFighter();
            }
            while (KeepPlaying());
        }
        public static void ChooseYourFighter()
        {
            Console.WriteLine("\nWould you like to play against Rocky or WildCard?");
            string playAgainst = Console.ReadLine().ToLower();
            switch (playAgainst)
            {
                case "rocky":
                    PlayAgainstRocky(playAgainst);
                    break;

                case "wildcard":
                    PlayAgainstWildCard(playAgainst);
                    break;
                default:
                    Console.WriteLine("\nLet me say this again....\n");
                    ChooseYourFighter();
                    break;
            }
        }

        public static void PlayAgainstWildCard(string playerName)
        {
            int playerwins1 = 0;
            int wcwins = 0;
            do
            {
                Roshambo throw1 = User.GenerateRoshambo();
                Roshambo throw2 = WildCard.GenerateRoshambo(); // complete all of the if statements needed
                if (throw1 == Roshambo.rock)
                {
                    if (throw2 == Roshambo.rock)
                    {
                        Console.WriteLine("\nDraw!");
                        Console.WriteLine($"\nThe score is WildCard: {wcwins}  You: {playerwins1}");

                    }
                    else if (throw2 == Roshambo.paper)
                    {
                        Console.WriteLine("\nWildCard won!");
                        wcwins++;
                        Console.WriteLine($"The score is Wildcard: {wcwins}  You: {playerwins1}");
                    }
                    else if (throw2 == Roshambo.scissors)
                    {
                        Console.WriteLine($"\n{playerName} wins!");
                        playerwins1++;
                        Console.WriteLine($"\nThe score is WildCard: {wcwins}  You: {playerwins1}");

                    }
                    else { }
                }
                else if (throw1 == Roshambo.paper)
                {
                    if (throw2 == Roshambo.rock)
                    {
                        Console.WriteLine($"\n{playerName} wins!");
                        playerwins1++;
                        Console.WriteLine($"The score is WildCard: {wcwins}  You: {playerwins1}");

                    }
                    else if (throw2 == Roshambo.paper)
                    {
                        Console.WriteLine("\nDraw!");
                        Console.WriteLine($"The score is WildCard: {wcwins}  You: {playerwins1}");

                    }
                    else if (throw2 == Roshambo.scissors)
                    {
                        Console.WriteLine("\nWildCard won!");
                        wcwins++;
                        Console.WriteLine($"The score is WildCard: {wcwins}  You: {playerwins1}");

                    }
                    else { }
                }
                else if (throw1 == Roshambo.scissors)
                {
                    if (throw2 == Roshambo.rock)
                    {
                        Console.WriteLine("\nWildCard won!");
                        wcwins++;
                        Console.WriteLine($"The score is WildCard: {wcwins}  You: {playerwins1}");

                    }
                    else if (throw2 == Roshambo.paper)
                    {
                        Console.WriteLine($"\n{playerName} wins!");
                        playerwins1++;
                        Console.WriteLine($"The score is WildCard: {wcwins}  You: {playerwins1}");

                    }
                    else if (throw2 == Roshambo.scissors)
                    {
                        Console.WriteLine("\nDraw!");
                        Console.WriteLine($"The score is WildCard: {wcwins}  You: {playerwins1}");

                    }
                    else { }
                }
                else { }
            } while (KeepPlayingWildCard());


        }
        public static void PlayAgainstRocky(string playerName)
        {
            int playerwins = 0;
            int rockywins = 0;
            do
            {
                Roshambo throw1 = User.GenerateRoshambo();
                Roshambo throw2 = Rocky.GenerateRoshambo();
                if (throw1 == Roshambo.rock && throw2 == Roshambo.rock)
                {
                    Console.WriteLine("\nDraw!");
                    Console.WriteLine($"The score is Rocky: {rockywins}  You: {playerwins}");
                }
                else if (throw1 == Roshambo.paper && throw2 == Roshambo.rock)
                {
                    Console.WriteLine($"\n{playerName} won!");
                    playerwins++;
                    Console.WriteLine($"The score is Rocky: {rockywins}  You: {playerwins}");

                }
                else if (throw1 == Roshambo.scissors && throw2 == Roshambo.rock)
                {
                    Console.WriteLine($"\nRocky won!");
                    rockywins++;
                    Console.WriteLine($"The score is Rocky: {rockywins}  You: {playerwins}");

                }
                else
                { }
            } while (KeepPlayingRocky());
        }

        public static bool KeepPlayingRocky()
        {
            Console.WriteLine($"\n Would you like to keep playing Rocky?: (y/n) ");
            string message = Console.ReadLine();
            if (message == "y" || message == "yes")
            {
                return true;
            }
            else if (message == "n" || message == "no")
            {
                return false;
            }
            else
            {
                return KeepPlayingRocky();
            }
        }

        public static bool KeepPlayingWildCard()
        {
            Console.WriteLine($"\n Would you like to keep playing WildCard?: (y/n) ");
            string message = Console.ReadLine();
            if (message == "y" || message == "yes")
            {
                return true;
            }
            else if (message == "n" || message == "no")
            {
                return false;
            }
            else
            {
                return KeepPlayingWildCard();
            }
        }

        public static bool KeepPlaying()
        {
            Console.WriteLine($"\n Would you like to keep playing?: (y/n) ");
            string message = Console.ReadLine();
            if (message == "y" || message == "yes")
            {
                return true;
            }
            else if (message == "n" || message == "no")
            {
                return false;
            }
            else
            {
                return KeepPlaying();
            }
        }
    }
}
