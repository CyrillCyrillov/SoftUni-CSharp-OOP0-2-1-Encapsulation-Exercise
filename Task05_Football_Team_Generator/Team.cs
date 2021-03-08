using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Task05_Football_Team_Generator
{
    public class Team
    {
        private string name;
        private List<Player> teamPlayers;

        public Team(string name)
        {
            Name = name;
            teamPlayers = new List<Player>();
        }

        public string Name
        {
            get => name;

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }

                name = value;
            }
        }

        public double Rating
        {
            get
            {
                return Math.Round(teamPlayers.Average(x => x.Stats));
            }
        }

        public void AddPlayer(Player player)
        {
            teamPlayers.Add(player);
        }

        public void RemovePlayer(string player)
        {
            Player playerToRemove = teamPlayers.FirstOrDefault(n => n.Name == player);

            if(playerToRemove == null)
            {
                throw new ArithmeticException($"Player {player} is not in {Name} team.");
            }

            teamPlayers.Remove(playerToRemove);
        }

        public override string ToString()
        {
            if(teamPlayers.Count > 0)
            {
                return $"{Name} - {Rating}";
            }
            else
            {
                return $"{Name} - 0";
            }
            
        }



    }
}
