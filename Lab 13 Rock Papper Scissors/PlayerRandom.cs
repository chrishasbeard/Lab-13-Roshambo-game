using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_13_Rock_Papper_Scissors
{
    class PlayerRandom : Player
    {
        public string ActuallyTrying { get; set; }

        public PlayerRandom(string actuallyTrying, string userPlayer): base(userPlayer)
        {
            ActuallyTrying = actuallyTrying;
        }

        public PlayerRandom()
        {

        }

        public override Roshambo GenerateRoshambo()
        {
            Random random = new Random();

            int randomNumber = random.Next(0, 3);

           return (Roshambo)Roshambo.Parse(typeof(Roshambo), randomNumber.ToString());
        }

    }
}
