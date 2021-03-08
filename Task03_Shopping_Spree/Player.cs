using System;
using System.Collections.Generic;
using System.Text;

namespace Task05_Football_Team_Generator
{
    public class Player
    {
        
        private string name;
        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;
        

        public Player(string name, int endurance, int sprint, int dribble, int passing, int shooting)
        {
            Name = name;
            Endurance =  endurance;
            Sprint = sprint;
            Dribble = dribble;
            Passing = passing;
            Shooting = shooting;
    }

        public string Name
        {
            get => name;
            private set
            {
                if(string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }

                name = value;
            }
        }

        public double Stats
        {
            get
            {
                return Math.Round((dribble + endurance + passing + shooting + sprint) / 5.0);
            }
        }

        private int Endurance
        {
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Endurance should be between 0 and 100.");
                }

                endurance = value;
            }
        }

        private int Sprint
        {
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Sprint should be between 0 and 100.");
                }

                sprint = value;
            }
        }

        private int Dribble
        {
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Dribble should be between 0 and 100.");
                }

                dribble = value;
            }
        }

        private int Passing
        {
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Passing should be between 0 and 100.");
                }

                passing = value;
            }
        }

        private int Shooting
        {
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Shooting should be between 0 and 100.");
                }

                shooting = value;
            }
        }
    }
}
