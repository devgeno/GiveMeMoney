using System;
using System.Collections.Generic;
using System.Text;

namespace GiveMeMoney
{
    class GameManager
    {
        private List<Player> players = new List<Player> {};

        public GameManager()
        {

        }

        public void AddPlayer(Player player)
        {
            players.Add(player);
        }
        
        public void Gaming()
        {
            Introduce();
            while(Playable())
            {
                Match();
            }
        }

        public void Match()
        {
            bool found = false;
            do
            {
                Console.Write("Enter an amount: ");
                int amount = Convert.ToInt32(Console.ReadLine());
                Console.Write("Who should give the cash: ");
                string name = Console.ReadLine();

                found = true;
            }
            while (!found);
        }

        public void Introduce()
        {
            foreach(Player player in players)
            {
                Console.WriteLine($"{player.Name}'s budget is {player.Money}.");
            }
        }

        public bool Playable()
        {
            bool playable = true;

            foreach (Player player in players)
            {
                if (player.Money <= 0)
                {
                    playable = false;
                }
            }
            return playable;

        }
    }
}
