using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_13_Rock_Papper_Scissors
{
    class PlayerRock : Player
    {
        public string NotTrying { get; set; }
        public PlayerRock() { }

        public PlayerRock (string notTrying, string userPlayer): base(userPlayer)
        {
            NotTrying = notTrying;
        }

        public override Roshambo GenerateRoshambo()
        {
            return Roshambo.rock;
        }


    }

}
