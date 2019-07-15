﻿using System;
using System.Collections.Generic;
using System.Text;

namespace P03_ShoppingSpree.Exceptions
{
    public static class ExceptionMessages
    {
        public static string NullOrEmptyNameException =
            "Name cannot be empty";
        public static string NegativeMoneyException =
            "Money cannot be negative";
        public static string CannotAffordProductException =
             "{0} can't afford {1}";
    }
}
    