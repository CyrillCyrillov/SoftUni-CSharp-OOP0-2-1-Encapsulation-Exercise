using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        List<Person> people = new List<Person>();
        List<Product> products = new List<Product>();

        string[] peopleInput = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
        string[] productsInput = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);

        try
        {
            foreach (string token in peopleInput)
            {
                string[] tokens = token.Split('=', StringSplitOptions.RemoveEmptyEntries);
                string name = tokens[0];
                double money = double.Parse(tokens[1]);

                Person person = new Person(name, money);
                people.Add(person);
            }

            foreach (string token in productsInput)
            {
                string[] info = token.Split('=', StringSplitOptions.RemoveEmptyEntries);
                string name = info[0];
                double cost = double.Parse(info[1]);

                Product product = new Product(name, cost);
                products.Add(product);
            }

            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                string[] info = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string personName = info[0];
                string productName = info[1];
                Product product = products.FirstOrDefault(p => p.Name == productName);

                try
                {
                    people.FirstOrDefault(p => p.Name == personName)
                          .BuyProduct(product);
                    Console.WriteLine($"{personName} bought {productName}");
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                }
            }

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return;
        }

        foreach (var per in people)
        {
            Console.WriteLine(per.ToString());
        }
    }
}

