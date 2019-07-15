using P03_ShoppingSpree.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace P03_ShoppingSpree.Core
{
    public class Engine
    {
        private List<Person> persons;
        private List<Product> products;

        public Engine()
        {
            this.persons = new List<Person>();
            this.products = new List<Product>();
        }
        public void Run()
        {
            try
            {
                ReadPersonsInput();

                ReadProductInput();

            }
            catch (ArgumentException ex)
            {

                Console.WriteLine(ex.Message);
                return;
            }

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "END")
            {
                try
                {
                    string[] commandTokens = command
                        .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();

                    string personName = commandTokens[0];
                    string productName = commandTokens[1];

                    Person person = this.persons
                        .FirstOrDefault(p => p.Name == personName);
                    Product product = this.products
                        .FirstOrDefault(p => p.Name == productName);

                    if (person != null && product != null)
                    {
                        person.BuyProduct(product);

                        Console.WriteLine($"{person.Name} bought {product.Name}");
                    }
                }
                catch (InvalidOperationException ioe)
                {

                    Console.WriteLine(ioe.Message);
                }
            }
            Console.WriteLine(string.Join(Environment.NewLine,this.persons));

        }

        private void ReadProductInput()
        {
            string[] productsToken = Console.ReadLine()
                 .Split(';', StringSplitOptions.RemoveEmptyEntries)
                 .ToArray();

            foreach (var pt in productsToken)
            {
                var token = pt
                    .Split('=', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string name = token[0];
                decimal cost = decimal.Parse(token[1]);

                Product product = new Product(name, cost);

                products.Add(product);
            }
        }

        private void ReadPersonsInput()
        {
            string[] personTokens = Console.ReadLine()
                .Split(';', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            foreach (var pt in personTokens)
            {
                var token = pt
                    .Split('=', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string name = token[0];
                decimal money = decimal.Parse(token[1]);

                Person person = new Person(name, money);

                persons.Add(person);
            }
        }
    }
}

