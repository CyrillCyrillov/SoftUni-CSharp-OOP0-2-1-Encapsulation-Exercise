using System;
using System.Linq;
using System.Collections.Generic;

namespace Task03_Shopping_Spree
{
    public class Program
    {
        static void Main(string[] args)
        {
            

            string[] dataLinePersons = Console.ReadLine().Split(new char[] { '=', ';' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            
            string[] dataLineProducts = Console.ReadLine().Split(new char[] { '=', ';' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            int peoplesNumbers = dataLinePersons.Length / 2;
            
            Dictionary<string, Person> allPersons = new Dictionary<string, Person>();

            try
            {
                for (int i = 0; i <= peoplesNumbers; i += 2)
                {
                    Person nextPerson = new Person(dataLinePersons[i], double.Parse(dataLinePersons[i + 1]));
                    allPersons.Add(dataLinePersons[i], nextPerson);
                }

                int productsNumber = dataLineProducts.Length / 2;

                Dictionary<string, Product> allProducts = new Dictionary<string, Product>();

                for (int i = 0; i <= peoplesNumbers; i += 2)
                {
                    Product nextProduct = new Product(dataLineProducts[i], double.Parse(dataLineProducts[i + 1]));
                    allProducts.Add(dataLineProducts[i], nextProduct);
                }

                int test = 1;

                string nextComand;
                while ((nextComand = Console.ReadLine()) != "END")
                {
                    string[] curentData = nextComand.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                    Person curentPerson = allPersons[curentData[0]];
                    Product curentProduct = allProducts[curentData[1]];

                    curentPerson.Bought(curentProduct);
                }




                foreach (var element in allPersons.Values)
                {
                    Console.WriteLine(element);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }




            //Console.WriteLine("Hello World!");
        }
    }
}
