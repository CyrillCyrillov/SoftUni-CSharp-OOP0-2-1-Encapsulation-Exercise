using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Task04_Pizza_Calories
{
    public class Pizza
    {
        private const int MaxToppings = 10;
        private const int NameMinLenght = 1;
        private const int NameMaxLenght = 15;
        
        private string name;
        private Dough dough;
        private List<Topping> toppings;

        public Pizza(string name, Dough dough)
        {
            Name = name;
            this.dough = dough;

            toppings = new List<Topping>();

        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                if (value.Length <= NameMinLenght || value.Length >= NameMaxLenght)
                {
                    throw new ArithmeticException($"Pizza name should be between {NameMinLenght} and {NameMaxLenght} symbols.");
                }


                name = value;
            }
        }

        public void AddTopping(Topping topping)
        {
            if(toppings.Count == 10)
            {
                throw new InvalidOperationException("Number of toppings should be in range [0..10].");
            }
            
            
            toppings.Add(topping);
        }

        public double GetCalories()
        {
            return dough.GetCalories() + toppings.Sum(t => t.GetCalories());

        }



        

    }
}
