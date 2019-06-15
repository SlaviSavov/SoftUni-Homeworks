﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace _05._Date_Modifier
{
    public static class DateModifier
    {
        public static double GetDaysBetweenDates(string dateOne, string dateTwo)
        {
            var firstDate = DateTime.ParseExact(dateOne, "yyyy MM dd", CultureInfo.InvariantCulture);
            var secondDate = DateTime.ParseExact(dateTwo, "yyyy MM dd", CultureInfo.InvariantCulture);

            if (firstDate > secondDate)
            {
                return GetDaysBetweenDates(dateTwo, dateOne);
            }

            return (secondDate - firstDate).Days;
        }
    }
}
