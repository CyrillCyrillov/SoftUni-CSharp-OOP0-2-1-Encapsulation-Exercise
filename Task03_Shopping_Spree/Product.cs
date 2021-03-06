using System;
using System.Collections.Generic;
using System.Text;

namespace Task03_Shopping_Spree
{
    public class Product
    {
        private string name;
        
        private double cost;

        public Product(string name, double cost)
        {
            Name = name;
            Cost = cost;
        }

        public string Name
        {
            get => name;

            private set
            {
                if(string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be an empty string.");
                }

                name = value;
            }
        }

        public double Cost
        {
            get => cost;
            
            private set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }

                cost = value;
            }
        }
    }
}
