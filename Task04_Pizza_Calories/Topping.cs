using System;
using System.Collections.Generic;
using System.Text;

namespace Task04_Pizza_Calories
{
    public class Topping
    {
        private const int MinWeight = 1;
        private const int MaxWeight = 50;

        private string name;
        private int weight;

        public Topping(string name, int weight)
        {
            Name = name;
            Weight = weight;
        }

        public string Name
        {
            get => name;

            private set
            {
                if(value.ToUpper() != "MEAT" && value.ToUpper() != "VEGGIES" && value.ToUpper() != "CHEESE" && value.ToUpper() != "SAUCE")
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }

                name = value;
            }
        }


        public int Weight
        {
            get => weight;

            private set
            {
                if (value < MinWeight || value > MaxWeight)
                {

                    throw new ArgumentException($"{Name} weight should be in the range[{MinWeight}..{MaxWeight}].");
                }

                weight = value;
            }
        }

        public double GetCalories()
        {
            double toppingModifier = GetToppingModifier();

            return Weight * 2 * toppingModifier;
        }

        private double GetToppingModifier()
        {
            switch (Name.ToUpper())
            {
                case "MEAT":
                    return 1.2;
                    break;

                case "VEGGIES":
                    return 0.8;
                    break;

                case "CHEESE":
                    return 1.1;
                    break;
                
                default: // SAUSE
                    return 0.9;
                    break;
            };
        }
    }
}
