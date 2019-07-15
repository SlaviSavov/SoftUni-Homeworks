using P03_ShoppingSpree.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace P03_ShoppingSpree.Models
{
    public class Person
    {
        private string name;
        private decimal money;
        private List<Product> bag;

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.NullOrEmptyNameException);
                }
                this.name = value;
            }
        }
        public decimal Money
        {
            get
            {
                return this.money;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException(ExceptionMessages.NegativeMoneyException);
                }
                this.money = value;
            }
        }

        public Person(string name, decimal money)
        {
            Name = name;
            Money = money;
            bag = new List<Product>();
        }

        public void BuyProduct(Product product)
        {
            decimal moneyLeft = money - product.Cost;

            if (moneyLeft <0)
            {
                throw new InvalidOperationException(string.Format(
                    ExceptionMessages.CannotAffordProductException,
                    this.name, product.Name));
            }
            this.Money = moneyLeft;
            this.bag.Add(product); 
        }

        public override string ToString()
        {
            if (bag.Count==0)
            {
                return $"{this.Name} - Nothing bought";
            }

            return $"{this.Name} - {string.Join(", ",bag)}";
        }
    }
}
