using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Task03_Shopping_Spree
{
    public class Person
    {
        private string name;

        private double money;

        private List<Product> products = new List<Product>();

        public Person(string name, double money)
        {
            Name = name;
            Money = money;

            List<Product> Products = new List<Product>(); 
        }
        
        public string Name
        {
            get => name;

            private set
            {
                if(string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }

                name = value;
            }
        }

        public double Money
        {
            get => money;
            
            private set
            {

                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }

                money = value;
            }
        }

        //public List<Product>  Products { get; set; }

        public void Bought(Product nextProduct)
        {

            try
            {
                if (Money - nextProduct.Cost < 0)
                {
                    throw new InvalidOperationException($"{Name} can't afford {nextProduct.Name}");
                }
                
                    Money -= nextProduct.Cost;
                    this.products.Add(nextProduct);
                    Console.WriteLine($"{Name} bought {nextProduct.Name}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        public override string ToString()
        {
            if(products.Count == 0)
            {
                return $"{Name} - Nothing bought";
            }
            else
            {
                return $"{Name} - {string.Join(", ", products.Select(n => n.Name))}";
            }
        }

    }
}
