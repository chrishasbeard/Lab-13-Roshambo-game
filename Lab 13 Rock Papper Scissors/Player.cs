using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_13_Rock_Papper_Scissors
{
    abstract class Player
    {
        public string Name { get; set; }

        public Roshambo Roshambo { get; set; }

        public Player(string name)
        {
            Name = name;
        }

        public Player()
        {

        }



        public abstract Roshambo GenerateRoshambo();
    }
   public enum Roshambo { rock, paper, scissors };
}
