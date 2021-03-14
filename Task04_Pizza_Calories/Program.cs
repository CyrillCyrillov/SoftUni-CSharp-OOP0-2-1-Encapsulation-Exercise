using System;
using System.Linq;

namespace Task04_Pizza_Calories
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string pizzaName = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)[1];

                string[] doughInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                string flourType = doughInfo[1];
                string bakingTechnique = doughInfo[2];
                int weight = int.Parse(doughInfo[3]);

                Dough curentDough = new Dough(flourType, bakingTechnique, weight);
                Pizza curentPizza = new Pizza(pizzaName, curentDough);

                while (true)
                {
                    string comand = Console.ReadLine();

                    if (comand == "END")
                    {
                        break;
                    }

                    string[] toppingInfo = comand.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                    string curentToppingName = toppingInfo[1];
                    int curentWeight = int.Parse(toppingInfo[2]);

                    Topping curentTopping = new Topping(curentToppingName, curentWeight);

                    curentPizza.AddTopping(curentTopping);
                }

                Console.WriteLine($"{curentPizza.Name} - {curentPizza.GetCalories():f2} Calories.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            

            //VIDEO 2:08

            //Console.WriteLine("Hello World!");
        }
    }
}
