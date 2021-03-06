﻿using System;
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

            try
            {
                Dictionary<string, Person> allPersons = new Dictionary<string, Person>();
                
                for (int i = 0; i <= dataLinePersons.Length-2; i += 2)
                {
                    Person nextPerson = new Person(dataLinePersons[i], double.Parse(dataLinePersons[i + 1]));
                    allPersons.Add(dataLinePersons[i], nextPerson);
                }

                Dictionary<string, Product> allProducts = new Dictionary<string, Product>();

                for (int i = 0; i <= dataLineProducts.Length - 2; i += 2)
                {
                    Product nextProduct = new Product(dataLineProducts[i], double.Parse(dataLineProducts[i + 1]));
                    allProducts.Add(dataLineProducts[i], nextProduct);
                }

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
