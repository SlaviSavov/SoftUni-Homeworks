using P03_ShoppingSpree.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace P03_ShoppingSpree.Models
{
    public class Product
    {
        private string name;
        private decimal cost;

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
        public decimal Cost
        {
            get
            {
                return this.cost;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException(ExceptionMessages.NegativeMoneyException);
                }
                this.cost = value;
            }
        }

        public Product(string name,decimal cost)
        {
            Name = name;
            Cost = cost;
        }
        public override string ToString()
        {
            return $"{this.Name}";
        }
    }
}
