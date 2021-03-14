using System;
using System.Collections.Generic;
using System.Text;

namespace Task04_Pizza_Calories
{
    public class Dough
    {
        private const int MinWeight = 1;
        private const int MaxWeight = 200;

        private string flourType;
        private string bakingTechnique;
        private int weight;

        public Dough(string flourType, string bakingTehnique, int weight)
        {
            FlourType = flourType;
            BakingTechnique = bakingTehnique;
            Weight = weight;
        }


        public string  FlourType
        {
            get => flourType;

            private set
            {
                if (value.ToUpper() != "WHITE" && value.ToUpper() != "WHOLEGRAIN")
                {
                    throw new ArithmeticException("Invalid type of dought.");
                }

                flourType = value;
            }

        }

        public string BakingTechnique
        {
            get => bakingTechnique;

            private set
            {
                if (value.ToUpper() != "CRISPY" && value.ToUpper() != "CHEWY" && value.ToUpper() != "HOMEMADE")
                {
                    throw new ArithmeticException("Invalid type of dought.");
                }
                
                bakingTechnique = value;
            }
        }

        public int Weight
        {
            get => weight;
            private set
            {
                if(value < MinWeight || value > MaxWeight)
                {

                    throw new ArgumentException($"Dough weight should be in the range [{MinWeight}..{MaxWeight}].");
                }

                weight = value;
            }
        }

        public double GetCalories()
        {
            double flourTypeModifier = GetFlourTypeModifier();
            double bakingTechniqueModifier = GetBakingTechniqueModifier();

            return Weight * 2 * flourTypeModifier * bakingTechniqueModifier;
        }

        private double GetBakingTechniqueModifier()
        {
            switch (BakingTechnique.ToUpper())
            {
                case "CRISPY":
                    return 0.9;
                    break;

                case "CHEWY":
                    return 1.1;
                    break;
                
                default: // "HOMEMADE"
                    return 1;
                    break;
            }
        }

        private double GetFlourTypeModifier()
        {
            
            if (FlourType.ToUpper() == "WHITE")
            {
                return 1.5;
            }

            return 1;

        }

    }
}
