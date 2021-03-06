﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01._Library
{
    public class Book : IComparable<Book>
    {
        public string Title { get; private set; }
        public int Year { get; private set; }
        public List<string> Autors { get; private set; }

        public Book(string title, int year, params string[] authors)
        {
            Title = title;
            Year = year;
            Autors = authors.ToList();
        }

        public int CompareTo(Book other)
        {
            if (this.Year!=other.Year)
            {
                return this.Year - other.Year;
            }
            if (this.Title!=other.Title)
            {
                return this.Title.CompareTo(other.Title);
            }
            return 0;
        }
        public override string ToString()
        {
            return $"{Title} - {Year}";
        }
    }
}
