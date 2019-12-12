using System.Collections.Generic;

namespace TextAdventure.Models
{
    public class Player
    {
        public string PlayerName { get; set; }
        public int Flower { get; set; }
        public int Sword { get; set; }
        public Player(string name)
        {
            PlayerName = name;
            Flower = 0;
            Sword = 0;
        }


    }
}